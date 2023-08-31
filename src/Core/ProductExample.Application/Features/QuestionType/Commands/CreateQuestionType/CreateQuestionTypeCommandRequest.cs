using Lms.Application.Features.Base;

namespace Lms.Application.Features.QuestionType.Commands.CreateQuestionType
{
    public class CreateQuestionTypeCommandRequest:BaseRequest
    {
        public string Name { get; set; }
    }
}
