using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.EventParticipants.Queries.GetEventParticipantsList
{
    public class GetEventParticipantsListQueryRequest : IRequest<IDataResult<IEnumerable<GetEventParticipantsListQueryResponse>>>
    {
    }
}
