using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Persistence.Repositories;
using Lms.Domain.Entities;
using Lms.Persistence.Context;
using Microsoft.Extensions.Logging;

namespace Lms.Persistence.Repositories
{
    public class AchievementCategoryRepository : AAuditableRepository<AchievementCategory, ApplicationDbContext>, IAchievementCategoryRepository
    {
        public AchievementCategoryRepository(ApplicationDbContext dbContext, ILogger<AchievementCategory> logger) : base(dbContext, logger)
        {
        }
    }
}
