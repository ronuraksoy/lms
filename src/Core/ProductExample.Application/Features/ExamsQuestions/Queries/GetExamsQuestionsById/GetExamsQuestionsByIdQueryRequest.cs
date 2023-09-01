using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.ExamsQuestions.Queries.GetExamsQuestionsById
{
    public class GetExamsQuestionsByIdQueryRequest : IRequest<IDataResult<GetExamsQuestionsByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetExamsQuestionsByIdQueryRequest(Guid Id) 
        {
            this.Id = Id;
        }
    }
}
