using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.ValidAnswers.Queries.GetValidAnswersById
{
    public class GetValidAnswersByIdQueryRequest : IRequest<IDataResult<GetValidAnswersByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetValidAnswersByIdQueryRequest(Guid Id) 
        {
            this.Id = Id;
        }
    }
}
