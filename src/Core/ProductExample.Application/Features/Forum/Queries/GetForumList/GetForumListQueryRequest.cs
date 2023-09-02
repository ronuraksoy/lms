using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.Forum.Queries.GetForumList
{
    public class GetForumListQueryRequest : IRequest<IDataResult<IEnumerable<GetForumListQueryResponse>>>
    {
    }
}
