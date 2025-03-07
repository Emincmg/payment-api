using PaymentProcessorDotnet.DTOs;
using PaymentProcessorDotnet.Interfaces;

namespace PaymentProcessorDotnet.Models.Strategy
{
    public class PayPalPayment : IPayment, IPaymentProcessor, IPaymentDecliner, IPaymentStrategy, IPaymentSuccessor
    {
        private readonly ILogger<PayPalPayment> _logger;
        private readonly IConfiguration _configuration;

        public PayPalPayment(IConfiguration configuration, ILogger<PayPalPayment> logger)
        {
            _configuration = configuration;
            _logger = logger;
        }

        public Task<PaymentDto> Process(PaymentDto paymentDto)
        {
            return null;
        }

        public PaymentDto Decline(PaymentDto dto)
        {
            throw new NotImplementedException();
        }

        public PaymentDto Success(PaymentDto dto)
        {
            throw new NotImplementedException();
        }

        public IPayment GetPayment(PaymentDto dto)
        {
            throw new NotImplementedException();
        }
    }
}