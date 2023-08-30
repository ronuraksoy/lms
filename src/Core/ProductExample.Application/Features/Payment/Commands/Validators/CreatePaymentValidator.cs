using FluentValidation;
using Lms.Application.Features.Payment.Commands.CreatePayment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.Payment.Commands.Validators
{
    public class CreatePaymentValidator : AbstractValidator<CreatePaymentCommandRequest>
    {
        public CreatePaymentValidator() { }
    }
}
