using PaymentProcessorDotnet.DTOs;

namespace PaymentProcessorDotnet.Interfaces.Payment;

public interface IPaymentSuccessor
{
    public PaymentDto Success(PaymentDto dto);
}
