using Lms.Application.Features.Teacher.Queries.GetCategoryById;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.Product.Queries.GetProductById
{
    public class GetProductByIdQueryRequest : IRequest<IDataResult<GetProductByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetProductByIdQueryRequest(Guid Id)
        {
            this.Id = Id;
        }
    }
}
