using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.ExamsQuestionsReport.Queries.GetExamsQuestionsReportById
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
