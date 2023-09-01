using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.AssignmentResult.Queries.GetAssignmentResultById
{
    public class GetAssignmentResultByIdQueryRequest : IRequest<IDataResult<GetAssignmentResultByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetAssignmentResultByIdQueryRequest(Guid Id) 
        {
            this.Id = Id;
        }
    }
}
