using PaymentProcessorApi.DTOs;

namespace PaymentProcessorApi.Interfaces.Payment;

public interface IPaymentDecliner
{
    public PaymentDto Decline(PaymentDto dto);
}
