using FluentValidation;
using Lms.Application.Features.Lessons.Commands.CreateLessons;

namespace Lms.Application.Features.Lessons.Commands.Validators
{
    public class CreateLessonsValidator: AbstractValidator<CreateLessonsCommandRequest>
    {
        public CreateLessonsValidator()
        {
            
        }
    }
}
