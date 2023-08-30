using Lms.Application.Features.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.Payment.Commands.CreatePayment
{
    public class CreatePaymentCommandRequest:BaseRequest
    {
        public string EducationPay { get; set; }
        public string Note { get; set; }
    }
}
