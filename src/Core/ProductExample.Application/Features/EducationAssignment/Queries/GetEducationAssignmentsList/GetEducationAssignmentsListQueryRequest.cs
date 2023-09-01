using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.EducationAssignments.Queries.GetEducationAssignmentsList
{
    public class GetEducationAssignmentsListQueryRequest : IRequest<IDataResult<IEnumerable<GetEducationAssignmentsListQueryResponse>>>
    {
    }
}
