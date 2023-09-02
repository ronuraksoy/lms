using Lms.Application.Features.Achievements.Queries.GetAchievementsPagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface IAchievementsRepository : IRepository<Achievements>
    {
        Task<IPagedData<Achievements>> GetPagedList(GetAchievementsPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
