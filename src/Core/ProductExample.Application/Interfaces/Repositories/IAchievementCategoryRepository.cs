using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading.Tasks;
using System.Threading;
using Lms.Application.Features.AchievementCategory.Queries.GetAchievementCategoryPagedList;

namespace Lms.Application.Interfaces.Repositories
{
    public interface IAchievementCategoryRepository : IRepository<AchievementCategory>
    {
        Task<IPagedData<AchievementCategory>> GetPagedList(GetAchievementCategoryPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
