using AutoMapper;
using PaymentProcessorApi.DTOs;
using PaymentProcessorApi.Interfaces.Payment;
using PaymentProcessorApi.Interfaces;

namespace PaymentProcessorApi.Mappings;

public class PaymentProfile : Profile
{
    public PaymentProfile()
    {
        CreateMap<IPayment, PaymentDto>().ReverseMap();
    }
}