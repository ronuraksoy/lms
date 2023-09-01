using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.EventType.Queries.GetEventTypeList
{
    public class GetEventTypeListQueryRequest : IRequest<IDataResult<IEnumerable<GetEventTypeListQueryResponse>>>
    {
    }
}
