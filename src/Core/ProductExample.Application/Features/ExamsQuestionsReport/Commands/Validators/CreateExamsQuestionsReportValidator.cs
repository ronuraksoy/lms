using FluentValidation;
using Lms.Application.Features.ExamsQuestionsReport.Commands.CreateExamsQuestionsReport;

namespace Lms.Application.Features.ExamsQuestionsReport.Commands.Validators
{
    public class CreateExamsQuestionsValidator : AbstractValidator<CreateExamsQuestionsCommandRequest>
    {
        public CreateExamsQuestionsValidator()
        {

        }
    }
}
