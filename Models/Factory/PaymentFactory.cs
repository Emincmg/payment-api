using AutoMapper;
using PaymentProcessorDotnet.DTOs;
using PaymentProcessorDotnet.Interfaces;
using PaymentProcessorDotnet.Models.Strategy;

namespace PaymentProcessorDotnet.Models.Factory;

public class PaymentFactory : IPaymentStrategy
{
    private readonly ILogger<PayPalPayment> _logger;
    private readonly IConfiguration _configuration;
    private readonly IMapper _mapper;
    private readonly PaymentDto _paymentDto;

    public PaymentFactory(ILogger <PayPalPayment>logger, IConfiguration configuration,IMapper mapper, PaymentDto paymentDto)
    {        
        _logger = logger;
        _configuration = configuration;
        _mapper = mapper;
        _paymentDto = paymentDto;
    }
    
    public IPayment GetPayment(PaymentDto dto)
    {
        return dto.PaymentMethod switch
        {
            "paypal" => new PayPalPayment(_configuration, _logger),
            _ => throw new NotImplementedException()
        };
    }
}