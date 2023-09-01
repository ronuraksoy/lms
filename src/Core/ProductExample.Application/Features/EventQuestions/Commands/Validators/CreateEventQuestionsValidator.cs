using FluentValidation;
using Lms.Application.Features.EventQuestions.Commands.CreateEventQuestions;

namespace Lms.Application.Features.EventQuestions.Commands.Validators
{
    public class CreateEventQuestionsValidator : AbstractValidator<CreateEventQuestionsCommandRequest>
    {
        public CreateEventQuestionsValidator()
        {

        }
    }
}
