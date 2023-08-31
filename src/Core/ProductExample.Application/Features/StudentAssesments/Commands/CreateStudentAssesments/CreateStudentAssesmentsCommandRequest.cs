using Lms.Application.Features.Base;

namespace Lms.Application.Features.StudentAssesments.Commands.CreateStudentAssesments
{
    public class CreateStudentAssesmentsCommandRequest : BaseRequest
    {
        public string Name { get; set; }
        public int Hour { get; set; }
    }
}
