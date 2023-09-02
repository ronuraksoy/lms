using FluentValidation;
using Lms.Application.Features.Curriculum.Commands.CreateCurriculum;

namespace Lms.Application.Features.Curriculum.Commands.Validators
{
    public class CreateCurriculumValidator : AbstractValidator<CreateCurriculumCommandRequest>
    {
        public CreateCurriculumValidator()
        {
        }
    }
}
