using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.Order.Queries.GetOrderById
{
    public class GetOrderByIdQueryRequest : IRequest<IDataResult<GetOrderByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetOrderByIdQueryRequest(Guid Id)
        {
            this.Id = Id;
        }
    }
}
