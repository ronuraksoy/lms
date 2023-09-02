using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.ForumCategory.Queries.GetForumCategoryList
{
    public class GetForumCategoryListQueryRequest : IRequest<IDataResult<IEnumerable<GetForumCategoryListQueryResponse>>>
    {
    }
}
