using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.Unit.Queries.GetUnitList
{
    public class GetUnitListQueryRequest : IRequest<IDataResult<IEnumerable<GetUnitListQueryResponse>>>
    {
    }
}
