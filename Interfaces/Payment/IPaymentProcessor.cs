using PaymentProcessorDotnet.DTOs;

namespace PaymentProcessorDotnet.Interfaces.Payment;

public interface IPaymentProcessor
{
    public Task<PaymentDto> Process(PaymentDto dto);
}