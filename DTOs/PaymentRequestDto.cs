namespace PaymentProcessorDotnet.DTOs;

public class PaymentRequestDto
{
    public string Channel { get; set; }
    public float Amount { get; set; }
    public string Currency { get; set; }
    public string Description { get; set; }
    public string? UserName { get; set; }
    public string? UserEmail { get; set; }
    public string? UserPhone { get; set; }
    public string? PaymentMethod { get; set; }
    public string? ConfirmationMethod { get; set; }

    public PaymentRequestDto(
        string channel,
        float amount,
        string currency,
        string description,
        string? userName = null,
        string? userEmail = null,
        string? userPhone = null,
        string? paymentMethod = null,
        string? confirmationMethod = null
    )
    {
        Channel = channel;
        Amount = amount;
        Currency = currency;
        Description = description;
        UserName = userName;
        UserEmail = userEmail;
        UserPhone = userPhone;
        PaymentMethod = paymentMethod;
        ConfirmationMethod = confirmationMethod;
    }
    
    /// <summary>
    /// Returns an instance of <see cref="PaymentRequestDto"/> from request data.
    /// </summary>
    /// <param name="data">The payment request data.</param>
    /// <returns>An instance of <see cref="PaymentRequestDto"/> created from the request data.</returns>
    public static PaymentRequestDto FromRequest(Dictionary<string, object> data)
    {
        return new PaymentRequestDto(
            (string)data["channel"],
            (float)data["amount"],
            (string)data["currency"],
            (string)data["description"],
            data.ContainsKey("userName") ? (string?)data["userName"] : null,
            data.ContainsKey("userEmail") ? (string?)data["userEmail"] : null,
            data.ContainsKey("userPhone") ? (string?)data["userPhone"] : null,
            data.ContainsKey("paymentMethod") ? (string?)data["paymentMethod"] : null,
            data.ContainsKey("confirmationMethod") ? (string?)data["confirmationMethod"] : null
        );
    }
}