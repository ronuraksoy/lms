using FluentValidation;
using Lms.Application.Features.Admin.Commands.CreateAdmin;

namespace Lms.Application.Features.Admin.Commands.Validators
{
    public class CreateAdminValidator: AbstractValidator<CreateAdminCommandRequest>
    {
        public CreateAdminValidator()
        {
            
        }
    }
}
