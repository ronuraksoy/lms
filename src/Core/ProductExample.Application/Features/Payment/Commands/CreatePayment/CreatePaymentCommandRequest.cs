using Lms.Application.Features.Base;

namespace Lms.Application.Features.Payment.Commands.CreatePayment
{
    public class CreatePaymentCommandRequest:BaseRequest
    {
        public string EducationPay { get; set; }
        public string Note { get; set; }
    }
}
