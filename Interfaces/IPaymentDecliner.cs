using PaymentProcessorDotnet.DTOs;

namespace PaymentProcessorDotnet.Interfaces;

public interface IPaymentDecliner
{
    public PaymentDto Decline(PaymentDto dto);
}