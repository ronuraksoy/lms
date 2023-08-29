using FluentValidation;
using Lms.Application.Features.AchievementCategory.Commands.CreateAchievementCategory;
using Lms.Application.Features.Teacher.Commands.CreateTeacher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.AchievementCategory.Commands.Validators
{
    public class CreateAchievementCategoryValidator: AbstractValidator<CreateAchievementCategoryCommandRequest>
    {
        public CreateAchievementCategoryValidator()
        {
            
        }
    }
}
