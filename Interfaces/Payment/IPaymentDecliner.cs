using PaymentProcessorDotnet.DTOs;

namespace PaymentProcessorDotnet.Interfaces.Payment;

public interface IPaymentDecliner
{
    public PaymentDto Decline(PaymentDto dto);
}