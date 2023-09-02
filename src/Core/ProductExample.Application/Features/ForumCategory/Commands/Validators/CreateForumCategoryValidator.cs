using FluentValidation;
using Lms.Application.Features.ForumCategory.Commands.CreateForumCategory;

namespace Lms.Application.Features.ForumCategory.Commands.Validators
{
    public class CreateForumCategoryValidator: AbstractValidator<CreateForumCategoryCommandRequest>
    {
        public CreateForumCategoryValidator()
        {
            
        }
    }
}
