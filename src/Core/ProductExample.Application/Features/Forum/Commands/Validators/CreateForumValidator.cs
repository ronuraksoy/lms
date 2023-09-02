using FluentValidation;
using Lms.Application.Features.Forum.Commands.CreateForum;

namespace Lms.Application.Features.Forum.Commands.Validators
{
    public class CreateForumValidator: AbstractValidator<CreateForumCommandRequest>
    {
        public CreateForumValidator()
        {
            
        }
    }
}
