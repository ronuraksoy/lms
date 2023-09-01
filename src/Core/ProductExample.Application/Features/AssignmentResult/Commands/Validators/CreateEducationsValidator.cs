using FluentValidation;
using Lms.Application.Features.AssignmentResult.Commands.CreateAssignmentResult;

namespace Lms.Application.Features.AssignmentResult.Commands.Validators
{
    public class CreateAssignmentResultValidator : AbstractValidator<CreateAssignmentResultCommandRequest>
    {
        public CreateAssignmentResultValidator()
        {
        }
    }
}
