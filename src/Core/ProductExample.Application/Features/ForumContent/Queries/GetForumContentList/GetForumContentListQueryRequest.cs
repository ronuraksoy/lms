using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.ForumContent.Queries.GetForumContentList
{
    public class GetForumContentListQueryRequest : IRequest<IDataResult<IEnumerable<GetForumContentListQueryResponse>>>
    {
    }
}
