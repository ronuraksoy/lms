using FluentValidation;
using Lms.Application.Features.Category.Commands.CreateCategory;

namespace Lms.Application.Features.Category.Commands.Validators
{
    public class CreateCategoryValidator: AbstractValidator<CreateCategoryCommandRequest>
    {
        public CreateCategoryValidator()
        {
            
        }
    }
}
