using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.Events.Queries.GetEventsList
{
    public class GetEventsListQueryRequest : IRequest<IDataResult<IEnumerable<GetEventsListQueryResponse>>>
    {
    }
}
