using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.EventQuestions.Queries.GetEventQuestionsById
{
    public class GetEventQuestionsByIdQueryRequest : IRequest<IDataResult<GetEventQuestionsByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetEventQuestionsByIdQueryRequest(Guid Id) 
        {
            this.Id = Id;
        }
    }
}
