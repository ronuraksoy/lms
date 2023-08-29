using FluentValidation;
using Lms.Application.Features.AchievementCategory.Commands.CreateAchievementCategory;

namespace Lms.Application.Features.AchievementCategory.Commands.Validators
{
    public class CreateCategoryValidator: AbstractValidator<CreateAchievementCategoryCommandRequest>
    {
        public CreateCategoryValidator()
        {
            
        }
    }
}
