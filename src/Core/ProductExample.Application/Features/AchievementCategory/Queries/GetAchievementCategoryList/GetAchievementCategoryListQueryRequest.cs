using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.AchievementCategory.Queries.GetAchievementCategoryList
{
    public class GetAchievementCategoryListQueryRequest : IRequest<IDataResult<IEnumerable<GetAchievementCategoryListQueryResponse>>>
    {
    }
}
