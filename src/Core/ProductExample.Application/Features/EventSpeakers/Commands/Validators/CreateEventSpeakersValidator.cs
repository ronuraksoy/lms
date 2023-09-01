using FluentValidation;
using Lms.Application.Features.EventSpeakers.Commands.CreateEventSpeakers;

namespace Lms.Application.Features.EventSpeakers.Commands.Validators
{
    public class CreateEventSpeakersValidator : AbstractValidator<CreateEventSpeakersCommandRequest>
    {
        public CreateEventSpeakersValidator()
        {

        }
    }
}
