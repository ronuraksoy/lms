using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.Achievements.Queries.GetAchievementsList
{
    public class GetAchievementsListQueryRequest : IRequest<IDataResult<IEnumerable<GetAchievementsListQueryResponse>>>
    {
    }
}
