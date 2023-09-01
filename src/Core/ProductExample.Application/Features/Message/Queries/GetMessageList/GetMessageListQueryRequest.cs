using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.Message.Queries.GetMessageList
{
    public class GetMessageListQueryRequest : IRequest<IDataResult<IEnumerable<GetMessageListQueryResponse>>>
    {
    }
}
