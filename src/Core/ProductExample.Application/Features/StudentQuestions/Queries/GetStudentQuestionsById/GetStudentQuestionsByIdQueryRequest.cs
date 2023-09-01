using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.StudentQuestions.Queries.GetStudentQuestionsById
{
    public class GetStudentQuestionsByIdQueryRequest : IRequest<IDataResult<GetStudentQuestionsByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetStudentQuestionsByIdQueryRequest(Guid Id) 
        {
            this.Id = Id;
        }
    }
}
