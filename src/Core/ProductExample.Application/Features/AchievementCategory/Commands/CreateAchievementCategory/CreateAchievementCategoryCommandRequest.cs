using Lms.Application.Features.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.AchievementCategory.Commands.CreateAchievementCategory
{
    public class CreateAchievementCategoryCommandRequest: BaseRequest
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
