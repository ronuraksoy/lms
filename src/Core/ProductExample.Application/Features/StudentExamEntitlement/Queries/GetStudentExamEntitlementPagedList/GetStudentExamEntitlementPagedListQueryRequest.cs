using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.StudentExamEntitlement.Queries.GetStudentExamEntitlementPagedList
{
    public class GetStudentExamEntitlementPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetStudentExamEntitlementPagedListQueryResponse>>
    {
    }
}
