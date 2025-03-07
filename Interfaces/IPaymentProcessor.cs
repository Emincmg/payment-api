using PaymentProcessorDotnet.DTOs;

namespace PaymentProcessorDotnet.Interfaces;

public interface IPaymentProcessor
{
    public Task<PaymentDto> Process(PaymentDto dto);
}