using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.Department.Queries.GetDepartmentPagedList
{
    public class GetDepartmentPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetDepartmentPagedListQueryResponse>>
    {
        public string? NameFilter { get; set; }
    }
}
