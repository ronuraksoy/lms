using Lms.Application.Features.Base;

namespace Lms.Application.Features.StudentExamEntitlement.Commands.CreateStudentExamEntitlement
{
    public class CreateStudentExamEntitlementCommandRequest : BaseRequest
    {
        public string Name { get; set; }
        public int Hour { get; set; }
    }
}
