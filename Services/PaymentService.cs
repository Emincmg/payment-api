using PaymentProcessorDotnet.DTOs;

namespace PaymentProcessorDotnet.Services;

public class PaymentService
{
    public PaymentResponseDto ProcessPayment(PaymentRequestDto paymentRequestDto)
    {
        return new PaymentResponseDto(
            "success",
            "transactionId123",
            "http://approval.url",
            "Payment processed successfully"
        );
    }
}