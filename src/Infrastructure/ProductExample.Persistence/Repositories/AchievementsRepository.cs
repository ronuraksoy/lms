using Lms.Application.Features.Achievements.Queries.GetAchievementsPagedList;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Comman.Persistence.Repositories;
using Lms.Domain.Entities;
using Lms.Persistence.Context;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Persistence.Repositories
{
    public class AchievementsRepository : AAuditableRepository<Achievements, ApplicationDbContext>, IAchievementsRepository
    {
        public AchievementsRepository(ApplicationDbContext dbContext, ILogger<Achievements> logger) : base(dbContext, logger)
        {
        }

        public Task<IPagedData<Achievements>> GetPagedList(GetAchievementsPagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
