using FluentValidation;
using Lms.Application.Features.Comment.Commands.CreateComment;

namespace Lms.Application.Features.Comment.Commands.Validators
{
    public class CreateCommentValidator : AbstractValidator<CreateCommentCommandRequest>
    {
        public CreateCommentValidator()
        {
        }
    }
}
