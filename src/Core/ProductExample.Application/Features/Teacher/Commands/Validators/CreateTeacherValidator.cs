using FluentValidation;
using Lms.Application.Features.Teacher.Commands.CreateTeacher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.Teacher.Commands.Validators
{
    public class CreateStudentValidator : AbstractValidator<CreateStudentCommandRequest>
    {
        public CreateStudentValidator()
        {
            RuleFor(p => p.Email)
                .NotNull()
                .WithMessage("Lütfen E-posta alanını boş geçmeyiniz.")
                .MinimumLength(10)
                .WithMessage("Lütfen en az 10 karakter giriniz...");
        }
    }
}
