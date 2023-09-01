using FluentValidation;
using Lms.Application.Features.User.Commands.CreateUser;

namespace Lms.Application.Features.User.Commands.Validators
{
    public class CreateUserValidator: AbstractValidator<CreateUserCommandRequest>
    {
        public CreateUserValidator()
        {
            
        }
    }
}
