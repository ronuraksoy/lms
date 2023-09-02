using Lms.Application.Features.ForumContent.Queries.GetForumContentPagedList;
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
    public class ForumContentRepository : AAuditableRepository<ForumContent, ApplicationDbContext>, IForumContentRepository
    {
        public ForumContentRepository(ApplicationDbContext dbContext, ILogger<ForumContent> logger) : base(dbContext, logger)
        {
        }

        public Task<IPagedData<ForumContent>> GetPagedList(GetForumContentPagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }
    }
}
