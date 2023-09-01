using FluentValidation;
using Lms.Application.Features.Order.Commands.CreateOrder;

namespace Lms.Application.Features.Order.Commands.Validators
{
    public class CreateorderValidator : AbstractValidator<CreateOrderCommandRequest>
    {
        public CreateorderValidator() { }
    }
}
