using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.StudentAssignments.Queries.GetStudentAssignmentsPagedList
{
    public class GetStudentAssignmentsPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetStudentAssignmentsPagedListQueryResponse>>
    {
    }
}
