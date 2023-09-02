using FluentValidation;
using Lms.Application.Features.Student.Commands.CreateStudent;

namespace Lms.Application.Features.Student.Commands.CreateStudent
{
    public class CreateStudentValidator : AbstractValidator<CreateStudentCommandRequest>
    {
        public CreateStudentValidator()
        {

        }
    }
}
