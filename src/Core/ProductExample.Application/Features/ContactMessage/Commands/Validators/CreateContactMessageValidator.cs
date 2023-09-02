using FluentValidation;
using Lms.Application.Features.ContactMessage.Commands.CreateContactMessage;

namespace Lms.Application.Features.ContactMessage.Commands.Validators
{
    public class CreateContactMessageValidator : AbstractValidator<CreateContactMessageCommandRequest>
    {
        public CreateContactMessageValidator()
        {
        }
    }
}
