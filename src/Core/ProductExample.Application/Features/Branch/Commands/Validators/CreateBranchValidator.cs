using FluentValidation;
using Lms.Application.Features.Branch.Commands.CreateBranch;

namespace Lms.Application.Features.Branch.Commands.Validators
{
    public class CreateBranchValidator : AbstractValidator<CreateBranchCommandRequest>
    {
        public CreateBranchValidator()
        {
        }
    }
}
