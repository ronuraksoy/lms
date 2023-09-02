using Lms.Application.Features.Base;

namespace Lms.Application.Features.Student.Commands.CreateStudent
{
    public class CreateStudentCommandRequest : BaseRequest
    {
        public string Name { get; set; }
        public int Hour { get; set; }
    }
}
