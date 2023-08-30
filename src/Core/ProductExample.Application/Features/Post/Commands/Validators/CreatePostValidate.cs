using FluentValidation;
using Lms.Application.Features.AchievementCategory.Commands.CreateAchievementCategory;
using Lms.Application.Features.Post.Commands.CreatePost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.Post.Commands.Validators
{
    public class CreatePostValidate: AbstractValidator<CreatePostCommandRequest>
    {
        public CreatePostValidate() { }
    }
}
