using FluentValidation;
using Lms.Application.Features.Product.Commands.CreateProduct;

namespace Lms.Application.Features.Product.Commands.Validators
{
    public class CreateProductValidator: AbstractValidator<CreateProductCommandRequest>
    {
        public CreateProductValidator() { }
    }
}
