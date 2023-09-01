using Lms.Application.Features.Base;

namespace Lms.Application.Features.ValidAnswers.Commands.CreateValidAnswers
{
    public class CreateValidAnswersCommandRequest : BaseRequest
    {
        public string Name { get; set; }
        public int Hour { get; set; }
    }
}
