using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.User.Queries.GetUserList
{
    public class GetUserListQueryRequest : IRequest<IDataResult<IEnumerable<GetUserListQueryResponse>>>
    {
    }
}
