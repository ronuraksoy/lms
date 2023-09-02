using FluentValidation;
using Lms.Application.Features.Contract.Commands.CreateContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.Contract.Commands.Validators
{
    public class CreateContractValidator : AbstractValidator<CreateContractCommandRequest>
    {
        public CreateContractValidator()
        {
        }
    }
}
