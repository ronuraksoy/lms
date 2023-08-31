using FluentValidation;
using Lms.Application.Features.Post.Commands.CreatePost;

namespace Lms.Application.Features.PostLike.Commands.Validators
{
    public class CreatePostLikeValidator : AbstractValidator<CreatePostCommandRequest>
    {
        public CreatePostLikeValidator() { }
    }
}
