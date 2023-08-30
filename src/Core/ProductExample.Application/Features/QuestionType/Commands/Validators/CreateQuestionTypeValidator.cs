using FluentValidation;
using Lms.Application.Features.Category.Commands.CreateCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.QuestionType.Commands.Validators
{
    public class CreateQuestionTypeValidator : AbstractValidator<CreateCategoryCommandRequest>
    {
        public CreateQuestionTypeValidator() { }
    }
}
