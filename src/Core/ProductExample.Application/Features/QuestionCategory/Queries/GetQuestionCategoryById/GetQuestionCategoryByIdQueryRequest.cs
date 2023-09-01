using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.QuestionCategory.Queries.GetQuestionCategoryById
{
    public class GetQuestionCategoryByIdQueryRequest: IRequest<IDataResult<GetQuestionCategoryByIdQueryResponse>>
    {
        public Guid Id { get; set; }
        public GetQuestionCategoryByIdQueryRequest(Guid Id)
        {
            this.Id = Id;
        }
    }
}
