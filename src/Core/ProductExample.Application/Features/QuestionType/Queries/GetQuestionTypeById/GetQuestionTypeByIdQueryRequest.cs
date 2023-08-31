using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.QuestionType.Queries.GetQuestionTypeById
{
    public class GetQuestionTypeByIdQueryRequest : IRequest<IDataResult<GetQuestionTypeByIdQueryResponse>>
    {
        public Guid Id { get; set; }
        public GetQuestionTypeByIdQueryRequest(Guid Id)
        {
            this.Id = Id;
        }
    }
}
