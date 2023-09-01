using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.Questions.Queries.GetQuestionById
{
    public class GetQuestionsByIdQueryRequest : IRequest<IDataResult<GetQuestionsByIdQueryResponse>>
    {
        public Guid Id { get; set; }
        public GetQuestionsByIdQueryRequest(Guid Id)
        {
            this.Id = Id;
        }
    }
}
