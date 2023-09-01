using FluentValidation;
using Lms.Application.Features.QuestionCategory.Commands.CreateQuestionCategory;

namespace Lms.Application.Features.QuestionCategory.Commands.Validators
{
    public class CreateQuestionCategoryValidator: AbstractValidator<CreateQuestionCategoryCommandRequest>
    {
        public CreateQuestionCategoryValidator() { }
    }
}
