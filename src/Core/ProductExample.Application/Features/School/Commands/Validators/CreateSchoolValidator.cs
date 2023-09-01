using FluentValidation;
using Lms.Application.Features.School.Commands.CreateSchool;

namespace Lms.Application.Features.School.Commands.Validators
{
    public class CreateSchoolValidator : AbstractValidator<CreateSchoolCommandRequest>
    {
        public CreateSchoolValidator()
        {
            RuleFor(p => p.Email)
                .NotNull()
                .WithMessage("Lütfen E-posta alanını boş geçmeyiniz.")
                .MinimumLength(10)
                .WithMessage("Lütfen en az 10 karakter giriniz...");
        }
    }
}
