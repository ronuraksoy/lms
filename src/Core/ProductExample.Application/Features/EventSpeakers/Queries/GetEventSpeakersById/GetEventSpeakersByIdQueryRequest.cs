using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.EventSpeakers.Queries.GetEventSpeakersById
{
    public class GetEventSpeakersByIdQueryRequest : IRequest<IDataResult<GetEventSpeakersByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetEventSpeakersByIdQueryRequest(Guid Id) 
        {
            this.Id = Id;
        }
    }
}
