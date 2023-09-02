using FluentValidation;
using Lms.Application.Features.CurriculumLesson.Commands.CreateCurriculumLesson;

namespace Lms.Application.Features.CurriculumLesson.Commands.Validators
{
    public class CreateCurriculumLessonValidator : AbstractValidator<CreateCurriculumLessonCommandRequest>
    {
        public CreateCurriculumLessonValidator()
        {
        }
    }
}
