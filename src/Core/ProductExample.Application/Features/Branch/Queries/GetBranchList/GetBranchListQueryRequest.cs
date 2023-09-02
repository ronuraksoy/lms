using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.Branch.Queries.GetBranchList
{
    public class GetBranchListQueryRequest : IRequest<IDataResult<IEnumerable<GetBranchListQueryResponse>>>
    {
    }
}
