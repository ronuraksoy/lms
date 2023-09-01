using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.StudentAssesments.Queries.GetStudentAssesmentsPagedList
{
    public class GetStudentAssesmentsPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetStudentAssesmentsPagedListQueryResponse>>
    {
    }
}
