using PaymentProcessorApi.DTOs;

namespace PaymentProcessorApi.Interfaces.Payment;

public interface IPaymentSuccessor
{
    public PaymentDto Success(PaymentDto dto);
}
