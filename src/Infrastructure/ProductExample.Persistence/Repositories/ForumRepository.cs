using Lms.Application.Features.Forum.Queries.GetForumPagedList;
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
    public class ForumRepository : AAuditableRepository<Forum, ApplicationDbContext>, IForumRepository
    {
        public ForumRepository(ApplicationDbContext dbContext, ILogger<Forum> logger) : base(dbContext, logger)
        {
        }

        public Task<IPagedData<Forum>> GetPagedList(GetForumPagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }
    }
}
