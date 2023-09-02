using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.Chat.Queries.GetChatList
{
    public class GetChatListQueryRequest : IRequest<IDataResult<IEnumerable<GetChatListQueryResponse>>>
    {
    }
}
