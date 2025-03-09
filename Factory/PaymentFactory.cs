using AutoMapper;
using PaymentProcessorApi.DTOs;
using PaymentProcessorApi.Interfaces.Payment;
using PaymentProcessorApi.Models.Strategy;

namespace PaymentProcessorApi.Factory;

public class PaymentFactory : IPaymentStrategy
{
    private readonly IMapper _mapper;

    public PaymentFactory(IMapper mapper)
    {
        _mapper = mapper;
    }
    
    public IPayment GetPayment(PaymentDto paymentDto)
    {
        return paymentDto.PaymentMethod switch
        {
            "paypal" => _mapper.Map<PayPalPayment>(paymentDto),
            "stripe"=> _mapper.Map<StripePayment>(paymentDto),
            _ => throw new NotImplementedException()
        };
    }
}