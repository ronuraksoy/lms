using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.Events.Queries.GetEventsById
{
    public class GetEventsByIdQueryRequest : IRequest<IDataResult<GetEventsByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetEventsByIdQueryRequest(Guid Id) 
        {
            this.Id = Id;
        }
    }
}
