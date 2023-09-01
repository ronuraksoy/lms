using Lms.Application.Features.Admin.Queries.GetAdminPagedList;
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
    public class AdminRepository : AAuditableRepository<Admin, ApplicationDbContext>, IAdminRepository
    {
        public AdminRepository(ApplicationDbContext dbContext, ILogger<Admin> logger) : base(dbContext, logger)
        {
        }

        public Task<IPagedData<Admin>> GetPagedList(GetAdminPagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }
    }
}
