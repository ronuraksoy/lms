using FluentValidation;
using Lms.Application.Features.Payment.Commands.CreatePayment;

namespace Lms.Application.Features.Payment.Commands.Validators
{
    public class CreatePaymentValidator : AbstractValidator<CreatePaymentCommandRequest>
    {
        public CreatePaymentValidator() { }
    }
}
