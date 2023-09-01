using FluentValidation;
using Lms.Application.Features.Events.Commands.CreateEvents;

namespace Lms.Application.Features.Events.Commands.Validators
{
    public class CreateEventsValidator : AbstractValidator<CreateEventsCommandRequest>
    {
        public CreateEventsValidator()
        {
        }
    }
}
