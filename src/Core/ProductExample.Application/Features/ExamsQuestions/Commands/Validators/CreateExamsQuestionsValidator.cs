using FluentValidation;
using Lms.Application.Features.ExamsQuestions.Commands.CreateExamsQuestions;

namespace Lms.Application.Features.ExamsQuestions.Commands.Validators
{
    public class CreateExamsQuestionsValidator : AbstractValidator<CreateExamsQuestionsCommandRequest>
    {
        public CreateExamsQuestionsValidator()
        {

        }
    }
}
