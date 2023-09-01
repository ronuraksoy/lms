using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.StudentAssignments.Queries.GetStudentAssignmentsList
{
    public class GetStudentAssignmentsListQueryRequest : IRequest<IDataResult<IEnumerable<GetStudentAssignmentsListQueryResponse>>>
    {
    }
}
