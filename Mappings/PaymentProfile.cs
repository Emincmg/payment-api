using AutoMapper;
using PaymentProcessorDotnet.DTOs;
using PaymentProcessorDotnet.Interfaces;
using PaymentProcessorDotnet.Interfaces.Payment;

namespace PaymentProcessorDotnet.Mappings;

public class PaymentProfile : Profile
{
    public PaymentProfile()
    {
        CreateMap<IPayment, PaymentDto>().ReverseMap();
    }
}