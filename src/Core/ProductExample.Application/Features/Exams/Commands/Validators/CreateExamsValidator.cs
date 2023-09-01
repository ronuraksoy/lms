using FluentValidation;
using Lms.Application.Features.Exams.Commands.CreateExams;

namespace Lms.Application.Features.Teacher.Commands.Validators
{
    public class CreateExamsValidator : AbstractValidator<CreateExamsCommandRequest>
    {
        public CreateExamsValidator()
        {

        }
    }
}
