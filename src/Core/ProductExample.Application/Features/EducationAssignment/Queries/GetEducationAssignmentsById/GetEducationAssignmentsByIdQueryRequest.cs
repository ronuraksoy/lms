using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.EducationAssignments.Queries.GetEducationAssignmentsById
{
    public class GetEducationAssignmentsByIdQueryRequest : IRequest<IDataResult<GetEducationAssignmentsByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetEducationAssignmentsByIdQueryRequest(Guid Id) 
        {
            this.Id = Id;
        }
    }
}
