using PaymentProcessorApi.DTOs;
using PaymentProcessorApi.Interfaces.Payment;

namespace PaymentProcessorApi.Models.Strategy;

public class StripePayment : IPayment
{
    public int Id { get; set; }
    public float Amount { get; set; }
    public required string Currency { get; set; }
    public required string Status { get; set; }
    public DateTime? ConfirmedAt { get; set; }
    public DateTime? DeclinedAt { get; set; }
    public int Tries { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public StripePayment(IConfiguration configuration, ILogger<StripePayment> logger)
    {
        
    }
    
    public Task<PaymentDto> Process(PaymentDto dto)
    {
        throw new NotImplementedException();
    }

    public PaymentDto Decline(PaymentDto dto)
    {
        throw new NotImplementedException();
    }

    public PaymentDto Success(PaymentDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<PaymentDto>? Process()
    {
        throw new NotImplementedException();
    }
}