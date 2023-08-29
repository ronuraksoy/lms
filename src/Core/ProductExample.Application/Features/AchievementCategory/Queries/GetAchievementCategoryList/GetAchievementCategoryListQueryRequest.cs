using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.Teacher.Queries.GetAchievementCategoryList
{
    public class GetAchievementCategoryListQueryRequest : IRequest<IDataResult<IEnumerable<GetAchievementCategoryListQueryResponse>>>
    {
    }
}
