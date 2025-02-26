using System.Text.Json;
using System.Xml.Linq;

namespace PaymentProcessorDotnet.DTOs;

public class PaymentResponseDto
{
    public string Status { get; set; }
    public string? TransactionId { get; set; }
    public string? ApprovalUrl { get; set; }
    public string? Message { get; set; }
    public Dictionary<string, string>? Keys { get; set; }
    
    /// <summary>
    /// Initializes a new instance of the <see cref="PaymentResponseDto"/> class.
    /// </summary>
    public PaymentResponseDto(
        string status,
        string? transactionId = null,
        string? approvalUrl = null,
        string? message = null,
        Dictionary<string, string>? keys = null
    )
    {
        Status = status;
        TransactionId = transactionId;
        ApprovalUrl = approvalUrl;
        Message = message;
        Keys = keys;
    }
    
    /// <summary>
    /// Creates a success response.
    /// </summary>
    public static PaymentResponseDto Success(string transactionId, string? approvalUrl = null)
    {
        return new PaymentResponseDto("success", transactionId, approvalUrl, "Payment successful.");
    }
    
    /// <summary>
    /// Creates a failure response.
    /// </summary>
    /// <param name="message">The failure message.</param>
    /// <returns>A <see cref="PaymentResponseDto"/> representing the failure.</returns>
    public static PaymentResponseDto Failure(string message)
    {
        return new PaymentResponseDto("failed", null, null, message);
    }
    
    /// <summary>
    /// Converts the response to a JSON format.
    /// </summary>
    /// <returns>A JSON string representing the response.</returns>
    public string ToJson()
    {
        return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
    }
    
    /// <summary>
    /// Converts the response to an XML format.
    /// </summary>
    /// <returns>An XML string representing the response.</returns>
    public string ToXml()
    {
        var xml = new XElement("PaymentResponse",
            new XElement("status", Status),
            new XElement("transactionId", TransactionId ?? string.Empty),
            new XElement("approvalUrl", ApprovalUrl ?? string.Empty),
            new XElement("message", Message ?? string.Empty)
        );

        if (Keys != null && Keys.Count > 0)
        {
            var keysNode = new XElement("keys");
            foreach (var key in Keys)
            {
                keysNode.Add(new XElement(key.Key, key.Value));
            }
            xml.Add(keysNode);
        }

        return xml.ToString();
    }
    
    /// <summary>
    /// Sets a specific key-value pair inside the keys dictionary.
    /// </summary>
    /// <param name="key">The key.</param>
    /// <param name="value">The value.</param>
    public void SetKey(string key, string value)
    {
        if (Keys == null)
        {
            Keys = new Dictionary<string, string>();
        }
        Keys[key] = value;
    }
    
    /// <summary>
    /// Gets a key value from the keys dictionary.
    /// </summary>
    /// <param name="key">The key.</param>
    /// <returns>The value associated with the key, or null if the key does not exist.</returns>
    public string? GetKey(string key)
    {
        return Keys != null && Keys.ContainsKey(key) ? Keys[key] : null;
    }
    
}