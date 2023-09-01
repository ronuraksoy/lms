using Lms.Application.Features.Base;

namespace Lms.Application.Features.StudentQuestions.Commands.CreateStudentQuestions
{
    public class CreateStudentQuestionsCommandRequest : BaseRequest
    {
        public string Name { get; set; }
        public int Hour { get; set; }
    }
}
