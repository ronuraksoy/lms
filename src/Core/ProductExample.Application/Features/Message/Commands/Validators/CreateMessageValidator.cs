using FluentValidation;
using Lms.Application.Features.Message.Commands.CreateMessage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.Message.Commands.Validators
{
    public class CreateMessageValidator : AbstractValidator<CreateMessageCommandRequest>
    {
        public CreateMessageValidator() { }
    }
}
