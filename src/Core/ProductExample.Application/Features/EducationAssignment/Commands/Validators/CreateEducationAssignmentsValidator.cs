using FluentValidation;
using Lms.Application.Features.EducationAssignments.Commands.CreateEducationAssignments;

namespace Lms.Application.Features.EducationAssignments.Commands.Validators
{
    public class CreateEducationAssignmentsValidator : AbstractValidator<CreateEducationAssignmentsCommandRequest>
    {
        public CreateEducationAssignmentsValidator()
        {
        }
    }
}
