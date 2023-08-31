using FluentValidation;
using Lms.Application.Features.StudentAssesments.Commands.CreateStudentAssesments;

namespace Lms.Application.Features.StudentAssesments.Commands.Validators
{
    public class CreateStudentAssesmentsValidator : AbstractValidator<CreateStudentAssesmentsCommandRequest>
    {
        public CreateStudentAssesmentsValidator()
        {
            
        }
    }
}
