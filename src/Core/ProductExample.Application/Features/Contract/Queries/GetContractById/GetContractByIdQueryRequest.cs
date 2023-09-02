using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.Contract.Queries.GetContractById
{
    public class GetContractByIdQueryRequest : IRequest<IDataResult<GetContractByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetContractByIdQueryRequest(Guid Id) 
        {
            this.Id = Id;
        }
    }
}
