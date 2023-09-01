using Lms.Application.Features.Exams.Queries.GetExamsPagedList;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Comman.Persistence.Repositories;
using Lms.Domain.Entities;
using Lms.Persistence.Context;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Persistence.Repositories
{
    public class ExamsRepository : AAuditableRepository<Exams, ApplicationDbContext>, IExamsRepository
    {
        public ExamsRepository(ApplicationDbContext dbContext, ILogger<Exams> logger) : base(dbContext, logger)
        {
        }

        public Task<IPagedData<Exams>> GetPagedList(GetExamsPagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
