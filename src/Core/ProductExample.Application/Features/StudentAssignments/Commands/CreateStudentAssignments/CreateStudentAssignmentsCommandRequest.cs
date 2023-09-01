using Lms.Application.Features.Base;

namespace Lms.Application.Features.StudentAssignments.Commands.CreateStudentAssignments
{
    public class CreateStudentAssignmentsCommandRequest : BaseRequest
    {
        public string Name { get; set; }
        public int Hour { get; set; }
    }
}
