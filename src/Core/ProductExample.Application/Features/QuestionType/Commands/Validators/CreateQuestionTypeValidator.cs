using FluentValidation;
using Lms.Application.Features.Category.Commands.CreateCategory;

namespace Lms.Application.Features.QuestionType.Commands.Validators
{
    public class CreateQuestionTypeValidator : AbstractValidator<CreateCategoryCommandRequest>
    {
        public CreateQuestionTypeValidator() { }
    }
}
