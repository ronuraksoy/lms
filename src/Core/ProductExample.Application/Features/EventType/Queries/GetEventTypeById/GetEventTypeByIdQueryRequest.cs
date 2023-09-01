using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.EventType.Queries.GetEventTypeById
{
    public class GetEventTypeByIdQueryRequest : IRequest<IDataResult<GetEventTypeByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetEventTypeByIdQueryRequest(Guid Id) 
        {
            this.Id = Id;
        }
    }
}
