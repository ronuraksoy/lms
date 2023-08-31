using Lms.Comman.Domain.Entities;
using MediatR;
using System;

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
