using PaymentProcessorDotnet.DTOs;

namespace PaymentProcessorDotnet.Interfaces;

public interface IPaymentDecliner
{
    public PaymentResponseDto Process(PaymentRequestDto requestDto);
}