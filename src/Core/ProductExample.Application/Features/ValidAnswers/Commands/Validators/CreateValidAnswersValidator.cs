using FluentValidation;
using Lms.Application.Features.ValidAnswers.Commands.CreateValidAnswers;

namespace Lms.Application.Features.ValidAnswers.Commands.Validators
{
    public class CreateValidAnswersValidator: AbstractValidator<CreateValidAnswersCommandRequest>
    {
        public CreateValidAnswersValidator()
        {
            
        }
    }
}
