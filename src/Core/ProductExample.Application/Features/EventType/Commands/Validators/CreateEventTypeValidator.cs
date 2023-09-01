using FluentValidation;
using Lms.Application.Features.EventType.Commands.CreateEventType;

namespace Lms.Application.Features.EventType.Commands.Validators
{
    public class CreateEventTypeValidator : AbstractValidator<CreateEventTypeCommandRequest>
    {
        public CreateEventTypeValidator()
        {
        }
    }
}
