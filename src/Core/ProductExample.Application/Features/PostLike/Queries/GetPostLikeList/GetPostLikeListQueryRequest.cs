using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.PostLike.Queries.GetPostLikeList
{
    public class GetPostLikeListQueryRequest: IRequest<IDataResult<IEnumerable<GetPostLikeListQueryResponse>>>
    {
    }
}
