using Lms.Application.Features.ForumCategory.Queries.GetForumCategoryPagedList;
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
    public class ForumCategoryRepository : AAuditableRepository<ForumCategory, ApplicationDbContext>, IForumCategoryRepository
    {
        public ForumCategoryRepository(ApplicationDbContext dbContext, ILogger<ForumCategory> logger) : base(dbContext, logger)
        {
        }

        public Task<IPagedData<ForumCategory>> GetPagedList(GetForumCategoryPagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }
    }
}
