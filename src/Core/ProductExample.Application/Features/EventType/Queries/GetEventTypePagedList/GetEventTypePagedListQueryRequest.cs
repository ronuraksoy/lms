using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.EventType.Queries.GetEventTypePagedList
{
    public class GetEventTypePagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetEventTypePagedListQueryResponse>>
    {
        public string? NameFilter { get; set; }
    }
}
