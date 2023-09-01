using Lms.Application.Features.Base;

namespace Lms.Application.Features.StudentAnswers.Commands.CreateStudentAnswers
{
    public class CreateStudentAnswersCommandRequest : BaseRequest
    {
        public string Name { get; set; }
        public int Hour { get; set; }
    }
}
