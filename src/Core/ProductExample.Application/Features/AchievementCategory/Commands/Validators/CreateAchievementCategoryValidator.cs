using FluentValidation;
using Lms.Application.Features.AchievementCategory.Commands.CreateAchievementCategory;

namespace Lms.Application.Features.AchievementCategory.Commands.Validators
{
    public class CreateAchievementCategoryValidator: AbstractValidator<CreateAchievementCategoryCommandRequest>
    {
        public CreateAchievementCategoryValidator()
        {
            
        }
    }
}
