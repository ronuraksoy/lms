using FluentValidation;
using Lms.Application.Features.EventParticipants.Commands.CreateEventParticipants;

namespace Lms.Application.Features.EventParticipants.Commands.Validators
{
    public class CreateEventParticipantsValidator : AbstractValidator<CreateEventParticipantsCommandRequest>
    {
        public CreateEventParticipantsValidator()
        {

        }
    }
}
