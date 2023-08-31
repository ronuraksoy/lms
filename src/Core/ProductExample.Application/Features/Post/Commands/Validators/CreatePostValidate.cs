using FluentValidation;
using Lms.Application.Features.Post.Commands.CreatePost;

namespace Lms.Application.Features.Post.Commands.Validators
{
    public class CreatePostValidate: AbstractValidator<CreatePostCommandRequest>
    {
        public CreatePostValidate() { }
    }
}
