using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.EventParticipants.Queries.GetEventParticipantsPagedList
{
    public class GetEventParticipantsPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetEventParticipantsPagedListQueryResponse>>
    {
        public string? NameFilter { get; set; }
    }
}
