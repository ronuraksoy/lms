using Lms.Application.Features.Semester.Queries.GetSemesterPagedList;
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
    public class SemesterRepository : AAuditableRepository<Semester, ApplicationDbContext>, ISemesterRepository
    {
        public SemesterRepository(ApplicationDbContext dbContext, ILogger<Semester> logger) : base(dbContext, logger)
        {
        }

        public Task<IPagedData<Semester>> GetPagedList(GetSemesterPagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }
    }
}