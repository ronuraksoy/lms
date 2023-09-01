using Lms.Application.Features.Unit.Queries.GetUnitPagedList;
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
    public class UnitRepository : AAuditableRepository<Unit, ApplicationDbContext>, IUnitRepository
    {
        public UnitRepository(ApplicationDbContext dbContext, ILogger<Unit> logger) : base(dbContext, logger)
        {
        }

        public Task<IPagedData<Unit>> GetPagedList(GetUnitPagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }
    }
}