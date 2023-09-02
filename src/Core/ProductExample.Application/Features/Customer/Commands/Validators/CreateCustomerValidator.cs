using FluentValidation;
using Lms.Application.Features.Customer.Commands.CreateCustomer;

namespace Lms.Application.Features.Customer.Commands.Validators
{
    public class CreateCustomerValidator : AbstractValidator<CreateCustomerCommandRequest>
    {
        public CreateCustomerValidator()
        {
        }
    }
}
