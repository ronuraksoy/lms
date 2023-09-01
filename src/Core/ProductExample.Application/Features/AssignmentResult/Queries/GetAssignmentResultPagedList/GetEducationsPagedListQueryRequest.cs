using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.AssignmentResult.Queries.GetAssignmentResultPagedList
{
    public class GetAssignmentResultPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetAssignmentResultPagedListQueryResponse>>
    {
        public string? NameFilter { get; set; }
    }
}
