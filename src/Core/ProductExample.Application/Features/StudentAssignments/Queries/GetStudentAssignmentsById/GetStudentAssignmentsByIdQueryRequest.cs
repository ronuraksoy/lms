using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.StudentAssignments.Queries.GetStudentAssignmentsById
{
    public class GetStudentAssignmentsByIdQueryRequest : IRequest<IDataResult<GetStudentAssignmentsByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetStudentAssignmentsByIdQueryRequest(Guid Id) 
        {
            this.Id = Id;
        }
    }
}
