using FluentValidation;
using Lms.Application.Features.Achievements.Commands.CreateAchievements;

namespace Lms.Application.Features.Achievements.Commands.Validators
{
    public class CreateAchievementsValidator: AbstractValidator<CreateAchievementsCommandRequest>
    {
        public CreateAchievementsValidator()
        {
            
        }
    }
}
