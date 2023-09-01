using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.Branch.Queries.GetBranchById
{
    public class GetBranchByIdQueryRequest : IRequest<IDataResult<GetBranchByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetBranchByIdQueryRequest(Guid Id) 
        {
            this.Id = Id;
        }
    }
}
