using Lms.Application.Features.Base;

namespace Lms.Application.Features.StudentExamLogs.Commands.CreateStudentExamLogs
{
    public class CreateStudentExamLogsCommandRequest : BaseRequest
    {
        public string Name { get; set; }
        public int Hour { get; set; }
    }
}
