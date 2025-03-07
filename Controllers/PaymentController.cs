using Microsoft.AspNetCore.Mvc;
using PaymentProcessorDotnet.Services;
using PaymentProcessorDotnet.DTOs;

namespace PaymentPRocessorDotnet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PaymentController : ControllerBase
    {
        private readonly PaymentService _paymentService;

        public PaymentController(PaymentService paymentService)
        {
            _paymentService = paymentService;
        }
        [HttpGet("process")]
                public IActionResult ProcessPayment()
                {
                    var requestDto = new PaymentDto(
                        "channel", // Replace with actual channel value
                        100.0f,    // Replace with actual amount
                        "currency", // Replace with actual currency
                        "description", // Replace with actual description
                        "optional1", // Replace with actual optional parameter or null
                        "optional2", // Replace with actual optional parameter or null
                        "optional3", // Replace with actual optional parameter or null
                        "optional4", // Replace with actual optional parameter or null
                        "optional5"  // Replace with actual optional parameter or null
                    );

                    
                    // Call the service and process the payment
                    var PaymentResponseDto = _paymentService.ProcessPayment(requestDto);

                    return Ok(PaymentResponseDto);
                }
    }
};
