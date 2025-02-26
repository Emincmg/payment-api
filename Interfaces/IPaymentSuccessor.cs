using PaymentProcessorDotnet.DTOs;

namespace PaymentProcessorDotnet.Interfaces;

public interface IPaymentSuccessor
{
    public PaymentResponseDto Process(PaymentRequestDto requestDto);
}