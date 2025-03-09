namespace PaymentProcessorApi.DTOs;

public class PaymentDto
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

    public PaymentDto(
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
}