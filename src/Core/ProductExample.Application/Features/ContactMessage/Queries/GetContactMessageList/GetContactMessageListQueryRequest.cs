using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.ContactMessage.Queries.GetContactMessageList
{
    public class GetContactMessageListQueryRequest : IRequest<IDataResult<IEnumerable<GetContactMessageListQueryResponse>>>
    {
    }
}
