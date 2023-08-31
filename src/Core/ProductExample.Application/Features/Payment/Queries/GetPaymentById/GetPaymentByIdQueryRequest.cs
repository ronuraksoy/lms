using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.Payment.Queries.GetPaymentById
{
    public class GetPaymentByIdQueryRequest : IRequest<IDataResult<GetPaymentByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetPaymentByIdQueryRequest(Guid Id)
        {
            this.Id = Id;
        }
    }
}
