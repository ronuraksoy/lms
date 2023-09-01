using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.EventSpeakers.Queries.GetEventSpeakersPagedList
{
    public class GetEventSpeakersPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetEventSpeakersPagedListQueryResponse>>
    {
        public string? NameFilter { get; set; }
    }
}
