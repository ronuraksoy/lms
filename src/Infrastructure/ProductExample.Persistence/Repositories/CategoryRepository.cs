using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Persistence.Repositories;
using Lms.Domain.Entities;
using Lms.Persistence.Context;
using Microsoft.Extensions.Logging;

namespace Lms.Persistence.Repositories
{
    public class CategoryRepository : AAuditableRepository<Category, ApplicationDbContext>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext dbContext, ILogger<Category> logger) : base(dbContext, logger)
        {
        }
    }
}
