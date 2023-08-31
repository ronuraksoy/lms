using Lms.Application.Features.Base;

namespace Lms.Application.Features.Category.Commands.CreateCategory
{
    public class CreateCategoryCommandRequest : BaseRequest
    {
        public string Name { get; set; }
        public int Hour { get; set; }
    }
}
