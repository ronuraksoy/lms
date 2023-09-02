using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.Chat.Queries.GetChatPagedList
{
    public class GetChatPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetChatPagedListQueryResponse>>
    {
        public string? NameFilter { get; set; }
    }
}
