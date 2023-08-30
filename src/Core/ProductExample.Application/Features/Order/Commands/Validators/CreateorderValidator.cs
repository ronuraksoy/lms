using FluentValidation;
using Lms.Application.Features.Order.Commands.CreateOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.Order.Commands.Validators
{
    public class CreateorderValidator : AbstractValidator<CreateOrderCommandRequest>
    {
        public CreateorderValidator() { }
    }
}
