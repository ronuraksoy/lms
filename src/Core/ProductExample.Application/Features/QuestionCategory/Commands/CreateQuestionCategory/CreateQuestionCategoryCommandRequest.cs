using Lms.Application.Features.Base;

namespace Lms.Application.Features.QuestionCategory.Commands.CreateQuestionCategory
{
    public class CreateQuestionCategoryCommandRequest : BaseRequest
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
