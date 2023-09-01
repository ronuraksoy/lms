using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.EventParticipants.Queries.GetEventParticipantsById
{
    public class GetEventParticipantsByIdQueryRequest : IRequest<IDataResult<GetEventParticipantsByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetEventParticipantsByIdQueryRequest(Guid Id) 
        {
            this.Id = Id;
        }
    }
}
