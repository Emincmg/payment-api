using PaymentProcessorDotnet.DTOs;

namespace PaymentProcessorDotnet.Interfaces;

public interface IPaymentSuccessor
{
    public PaymentDto Success(PaymentDto dto);
}