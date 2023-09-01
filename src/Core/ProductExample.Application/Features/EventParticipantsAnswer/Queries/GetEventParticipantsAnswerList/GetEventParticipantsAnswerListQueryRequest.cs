using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.EventParticipantsAnswer.Queries.GetEventParticipantsAnswerList
{
    public class GetEventParticipantsAnswerListQueryRequest : IRequest<IDataResult<IEnumerable<GetEventParticipantsAnswerListQueryResponse>>>
    {
    }
}
