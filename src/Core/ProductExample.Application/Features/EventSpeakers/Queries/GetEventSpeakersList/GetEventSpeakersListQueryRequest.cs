using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.EventSpeakers.Queries.GetEventSpeakersList
{
    public class GetEventSpeakersListQueryRequest : IRequest<IDataResult<IEnumerable<GetEventSpeakersListQueryResponse>>>
    {
    }
}
