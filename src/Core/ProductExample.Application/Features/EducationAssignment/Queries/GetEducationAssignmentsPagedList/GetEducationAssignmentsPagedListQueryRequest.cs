using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.EducationAssignments.Queries.GetEducationAssignmentsPagedList
{
    public class GetEducationAssignmentsPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetEducationAssignmentsPagedListQueryResponse>>
    {

    }
}
