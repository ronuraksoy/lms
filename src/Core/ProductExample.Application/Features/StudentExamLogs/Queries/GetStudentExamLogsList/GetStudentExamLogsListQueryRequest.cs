using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.StudentExamLogs.Queries.GetStudentExamLogsList
{
    public class GetStudentExamLogsListQueryRequest : IRequest<IDataResult<IEnumerable<GetStudentExamLogsListQueryResponse>>>
    {
    }
}
