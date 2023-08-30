using Lms.Application.Features.Category.Queries.GetCategoryPagedList;
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
    public class CategoryRepository : AAuditableRepository<Category, ApplicationDbContext>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext dbContext, ILogger<Category> logger) : base(dbContext, logger)
        {
        }

        public Task<IPagedData<Category>> GetPagedList(GetCategoryPagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }
    }
}
