using FluentValidation;
using Lms.Application.Features.Classrooms.Commands.CreateClassrooms;

namespace Lms.Application.Features.Classrooms.Commands.Validators
{
    public class CreateClassroomsValidator : AbstractValidator<CreateClassroomsCommandRequest>
    {
        public CreateClassroomsValidator()
        {
        }
    }
}
