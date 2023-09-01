using Lms.Application.Features.Base;

namespace Lms.Application.Features.AchievementCategory.Commands.CreateAchievementCategory
{
    public class CreateAchievementCategoryCommandRequest: BaseRequest
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
