using PaymentProcessorApi.DTOs;

namespace PaymentProcessorApi.Interfaces.Payment;

public interface IPaymentProcessor
{
    public Task<PaymentDto>? Process();
}
