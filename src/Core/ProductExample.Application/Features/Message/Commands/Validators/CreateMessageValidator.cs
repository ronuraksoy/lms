using FluentValidation;
using Lms.Application.Features.Message.Commands.CreateMessage;

namespace Lms.Application.Features.Message.Commands.Validators
{
    public class CreateMessageValidator : AbstractValidator<CreateMessageCommandRequest>
    {
        public CreateMessageValidator() { }
    }
}
