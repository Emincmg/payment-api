using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using PaymentProcessorApi.DTOs;
using PaymentProcessorApi.Services;

namespace PaymentProcessorApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PaymentController : ControllerBase
    {
        private readonly PaymentService _paymentService;
        private readonly IDataProtector _dataProtector;

        public PaymentController(PaymentService paymentService, IDataProtectionProvider dataProtectionProvider)
        {
            _dataProtector = dataProtectionProvider.CreateProtector(nameof(PaymentController));
            _paymentService = paymentService;
        }

        [HttpPost("process")]
        public async Task<IActionResult> ProcessPayment([FromBody] PaymentDto paymentDto)
        {
            // call the service, set the payment & process the payment
            _paymentService.SetPayment(paymentDto); 
            await _paymentService.ProcessPayment()!;

            return Ok(paymentDto);
        }
    }
};
