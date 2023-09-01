using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.StudentExamLogs.Queries.GetStudentExamLogsById
{
    public class GetStudentExamLogsByIdQueryRequest : IRequest<IDataResult<GetStudentExamLogsByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetStudentExamLogsByIdQueryRequest(Guid Id) 
        {
            this.Id = Id;
        }
    }
}
