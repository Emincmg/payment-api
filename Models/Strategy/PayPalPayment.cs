using PaymentProcessorApi.DTOs;
using PaymentProcessorApi.Interfaces.Payment;

namespace PaymentProcessorApi.Models.Strategy
{
    public class PayPalPayment : IPayment
    {
        private readonly ILogger<PayPalPayment> _logger;
        private readonly IConfiguration _configuration;
        public int Id { get; set; }
        public float Amount { get; set; }
        public required string Currency { get; set; }
        public string Status { get; set; } = "pending";
        public DateTime? ConfirmedAt { get; set; }
        public DateTime? DeclinedAt { get; set; }
        public int Tries { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        
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

        public IPayment GetPayment()
        {
            throw new NotImplementedException();
        }

        public Task<PaymentDto>? Process()
        {
            throw new NotImplementedException();
        }
    }
}