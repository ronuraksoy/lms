using Lms.Application.Features.School.Queries.GetSchoolPagedList;
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
    public class SchoolRepository : AAuditableRepository<School, ApplicationDbContext>, ISchoolRepository
    {
        public SchoolRepository(ApplicationDbContext dbContext, ILogger<School> logger) : base(dbContext, logger)
        {
        }

        public Task<IPagedData<School>> GetPagedList(GetSchoolPagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }
    }
}
