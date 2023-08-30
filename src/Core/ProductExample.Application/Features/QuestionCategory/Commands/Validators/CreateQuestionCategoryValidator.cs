using FluentValidation;
using Lms.Application.Features.QuestionCategory.Commands.CreateQuestionCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.QuestionCategory.Commands.Validators
{
    public class CreateQuestionCategoryValidator: AbstractValidator<CreateQuestionCategoryCommandRequest>
    {
        public CreateQuestionCategoryValidator() { }
    }
}
