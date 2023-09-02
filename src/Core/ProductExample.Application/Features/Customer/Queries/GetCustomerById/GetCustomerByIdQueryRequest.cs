using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.Customer.Queries.GetCustomerById
{
    public class GetCustomerByIdQueryRequest : IRequest<IDataResult<GetCustomerByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetCustomerByIdQueryRequest(Guid Id) 
        {
            this.Id = Id;
        }
    }
}
