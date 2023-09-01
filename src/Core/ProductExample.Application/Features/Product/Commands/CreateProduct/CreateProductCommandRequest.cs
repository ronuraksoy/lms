using Lms.Application.Features.Base;
using System;

namespace Lms.Application.Features.Product.Commands.CreateProduct
{
    public class CreateProductCommandRequest:BaseRequest
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public Guid OrderId { get; set; }
        public Guid Order { get; set; }

    }
}
