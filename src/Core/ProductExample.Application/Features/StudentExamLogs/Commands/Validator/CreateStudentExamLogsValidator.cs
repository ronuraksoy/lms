using FluentValidation;
using Lms.Application.Features.StudentExamLogs.Commands.CreateStudentExamLogs;

namespace Lms.Application.Features.StudentExamLogs.Commands.Validators
{
    public class CreateStudentExamLogsValidator: AbstractValidator<CreateStudentExamLogsCommandRequest>
    {
        public CreateStudentExamLogsValidator()
        {
            
        }
    }
}
