using FluentValidation;
using Lms.Application.Features.Questions.Commands.CreateQuestions;

namespace Lms.Application.Features.Questions.Commands.Validators
{
    public class CreateQuestionsValidator : AbstractValidator<CreateQuestionsCommandRequest>
    {
        public CreateQuestionsValidator() { }
    }
}
