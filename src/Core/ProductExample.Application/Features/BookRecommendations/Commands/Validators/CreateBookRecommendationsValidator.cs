using FluentValidation;
using Lms.Application.Features.BookRecommendations.Commands.CreateBookRecommendations;

namespace Lms.Application.Features.BookRecommendations.Commands.Validators
{
    public class CreateBookRecommendationsValidator : AbstractValidator<CreateBookRecommendationsCommandRequest>
    {
        public CreateBookRecommendationsValidator()
        {
        }
    }
}
