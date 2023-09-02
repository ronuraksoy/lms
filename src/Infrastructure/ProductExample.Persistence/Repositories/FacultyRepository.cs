using Lms.Application.Features.Faculty.Queries.GetFacultyPagedList;
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
    public class FacultyRepository : AAuditableRepository<Faculty, ApplicationDbContext>, IFacultyRepository
    {
        public FacultyRepository(ApplicationDbContext dbContext, ILogger<Faculty> logger) : base(dbContext, logger)
        {
        }

        public Task<IPagedData<Faculty>> GetPagedList(GetFacultyPagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }
    }
}
