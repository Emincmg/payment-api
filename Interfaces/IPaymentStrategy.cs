using PaymentProcessorDotnet.DTOs;

namespace PaymentProcessorDotnet.Interfaces
{
    public interface IPaymentStrategy
    {
        public IPayment GetPayment(PaymentDto dto);
    }
};
