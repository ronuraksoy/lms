using FluentValidation;
using Lms.Application.Features.Faculty.Commands.CreateFaculty;

namespace Lms.Application.Features.Faculty.Commands.Validators
{
    public class CreateFacultyValidator: AbstractValidator<CreateFacultyCommandRequest>
    {
        public CreateFacultyValidator()
        {
            
        }
    }
}
