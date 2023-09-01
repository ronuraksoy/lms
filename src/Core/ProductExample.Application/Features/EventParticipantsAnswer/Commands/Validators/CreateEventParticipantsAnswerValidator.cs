using FluentValidation;
using Lms.Application.Features.EventParticipantsAnswer.Commands.CreateEventParticipantsAnswer;

namespace Lms.Application.Features.EventParticipantsAnswer.Commands.Validators
{
    public class CreateEventParticipantsAnswerValidator : AbstractValidator<CreateEventParticipantsAnswerCommandRequest>
    {
        public CreateEventParticipantsAnswerValidator()
        {

        }
    }
}
