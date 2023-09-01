using FluentValidation;
using Lms.Application.Features.Educations.Commands.CreateEducations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.Educations.Commands.Validators
{
    public class CreateEducationsValidator : AbstractValidator<CreateEducationsCommandRequest>
    {
        public CreateEducationsValidator()
        {
        }
    }
}
