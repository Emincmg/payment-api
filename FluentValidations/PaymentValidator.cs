using FluentValidation;
using PaymentProcessorDotnet.Interfaces.Payment;
using PaymentProcessorDotnet.Models.Strategy;

namespace PaymentProcessorDotnet.FluentValidations;

public class PaymentValidator
{
    private readonly IValidator<PayPalPayment> _payPalPaymentValidator;
    private readonly IValidator<StripePayment> _stripePaymentValidator;

    public PaymentValidator(IValidator<PayPalPayment> payPalPaymentValidator, IValidator<StripePayment> stripePaymentValidator)
    {
        _payPalPaymentValidator = payPalPaymentValidator;
        _stripePaymentValidator = stripePaymentValidator;
    }

    public void Validate(IPayment payment)
    {
        if (payment is PayPalPayment payPalPayment)
        {
            var validationResult = _payPalPaymentValidator.Validate(payPalPayment);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }
        }
        else if (payment is StripePayment stripePayment)
        {
            var validationResult = _stripePaymentValidator.Validate(stripePayment);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }
        }
        else
        {
            throw new ArgumentException("Invalid payment type");
        }
    }
}
