using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.AssignmentResult.Queries.GetAssignmentResultList
{
    public class GetAssignmentResultListQueryRequest : IRequest<IDataResult<IEnumerable<GetAssignmentResultListQueryResponse>>>
    {
    }
}
