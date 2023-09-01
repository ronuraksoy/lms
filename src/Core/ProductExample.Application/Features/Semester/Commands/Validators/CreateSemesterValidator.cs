using FluentValidation;
using Lms.Application.Features.Semester.Commands.CreateSemester;

namespace Lms.Application.Features.Semester.Commands.Validators
{
    public class CreateSemesterValidator : AbstractValidator<CreateSemesterCommandRequest>
    {
        public CreateSemesterValidator()
        {

        }
    }
}
