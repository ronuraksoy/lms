using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.Branch.Queries.GetBranchPagedList
{
    public class GetBranchPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetBranchPagedListQueryResponse>>
    {
        public string? NameFilter { get; set; }
    }
}
