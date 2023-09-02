using FluentValidation;
using Lms.Application.Features.ForumContent.Commands.CreateForumContent;

namespace Lms.Application.Features.ForumContent.Commands.Validators
{
    public class CreateForumContentValidator: AbstractValidator<CreateForumContentCommandRequest>
    {
        public CreateForumContentValidator()
        {
            
        }
    }
}
