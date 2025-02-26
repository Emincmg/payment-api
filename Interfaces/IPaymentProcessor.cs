using PaymentProcessorDotnet.DTOs;

namespace PaymentProcessorDotnet.Interfaces;

public interface IPaymentProcessor
{
    public PaymentResponseDto Process(PaymentRequestDto requestDto);
}