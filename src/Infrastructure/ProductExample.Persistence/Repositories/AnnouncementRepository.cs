using Lms.Application.Features.Announcement.Queries.GetAnnouncementPagedList;
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
    public class AnnouncementRepository : AAuditableRepository<Announcement, ApplicationDbContext>, IAnnouncementRepository
    {
        public AnnouncementRepository(ApplicationDbContext dbContext, ILogger<Announcement> logger) : base(dbContext, logger)
        {
        }

        public Task<IPagedData<Announcement>> GetPagedList(GetAnnouncementPagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }
    }
}
