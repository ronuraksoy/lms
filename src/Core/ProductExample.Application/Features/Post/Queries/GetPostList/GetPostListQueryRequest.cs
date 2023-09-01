using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.Post.Queries.GetPostList
{
    public class GetPostListQueryRequest : IRequest<IDataResult<IEnumerable<GetPostListQueryResponse>>>
    {
    }
}
