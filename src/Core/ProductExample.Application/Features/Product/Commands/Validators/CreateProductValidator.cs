using FluentValidation;
using Lms.Application.Features.Product.Commands.CreateProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.Product.Commands.Validators
{
    public class CreateProductValidator: AbstractValidator<CreateProductCommandRequest>
    {
        public CreateProductValidator() { }
    }
}
