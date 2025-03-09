using PaymentProcessorApi.DTOs;

namespace PaymentProcessorApi.Interfaces.Payment;

public interface IPaymentStrategy
{
    public IPayment GetPayment(PaymentDto paymentDto);
}
