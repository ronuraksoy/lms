using FluentValidation;
using Lms.Application.Features.Department.Commands.CreateDepartment;

namespace Lms.Application.Features.Department.Commands.Validators
{
    public class CreateDepartmentValidator : AbstractValidator<CreateDepartmentCommandRequest>
    {
        public CreateDepartmentValidator()
        {
        }
    }
}
