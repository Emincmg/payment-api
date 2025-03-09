using PaymentProcessorDotnet.DTOs;

namespace PaymentProcessorDotnet.Interfaces.Payment;

public interface IPaymentStrategy
{
    public IPayment GetPayment(PaymentDto paymentDto);
}
