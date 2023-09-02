using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.StudentAnswers.Queries.GetStudentAnswersById
{
    public class GetStudentAnswersByIdQueryRequest : IRequest<IDataResult<GetStudentAnswersByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetStudentAnswersByIdQueryRequest(Guid Id) 
        {
            this.Id = Id;
        }
    }
}
