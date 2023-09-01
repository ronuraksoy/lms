using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.EventParticipantsAnswer.Queries.GetEventParticipantsAnswerPagedList
{
    public class GetEventParticipantsAnswerPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetEventParticipantsAnswerPagedListQueryResponse>>
    {
        public string? NameFilter { get; set; }
    }
}
