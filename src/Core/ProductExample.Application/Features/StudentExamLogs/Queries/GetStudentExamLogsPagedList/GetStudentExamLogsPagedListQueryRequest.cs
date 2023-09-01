using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.StudentExamLogs.Queries.GetStudentExamLogsPagedList
{
    public class GetStudentExamLogsPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetStudentExamLogsPagedListQueryResponse>>
    {
    }
}
