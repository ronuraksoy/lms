using Lms.Application.Features.AchievementCategory.Queries.GetAchievementCategoryPagedList;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Comman.Persistence.Repositories;
using Lms.Domain.Entities;
using Lms.Persistence.Context;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Persistence.Repositories
{
    public class AchievementCategoryRepository : AAuditableRepository<AchievementCategory, ApplicationDbContext>, IAchievementCategoryRepository
    {
        public AchievementCategoryRepository(ApplicationDbContext dbContext, ILogger<AchievementCategory> logger) : base(dbContext, logger)
        {
        }

        public Task<IPagedData<AchievementCategory>> GetPagedList(GetAchievementCategoryPagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }
    }
}
