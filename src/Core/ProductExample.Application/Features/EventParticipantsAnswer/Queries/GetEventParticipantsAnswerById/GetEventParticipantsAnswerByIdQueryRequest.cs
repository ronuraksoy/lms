using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.EventParticipantsAnswer.Queries.GetEventParticipantsAnswerById
{
    public class GetEventParticipantsAnswerByIdQueryRequest : IRequest<IDataResult<GetEventParticipantsAnswerByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetEventParticipantsAnswerByIdQueryRequest(Guid Id) 
        {
            this.Id = Id;
        }
    }
}
