using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.Events.Queries.GetEventsPagedList
{
    public class GetEventsPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetEventsPagedListQueryResponse>>
    {
        public string? NameFilter { get; set; }
    }
}
