using Lms.Application.Features.AssignmentResult.Queries.GetAssignmentResultPagedList;
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
    public class AssignmentResultRepository : AAuditableRepository<AssignmentResult, ApplicationDbContext>, IAssignmentResultRepository
    {
        public AssignmentResultRepository(ApplicationDbContext dbContext, ILogger<AssignmentResult> logger) : base(dbContext, logger)
        {
        }

        public Task<IPagedData<AssignmentResult>> GetPagedList(GetAssignmentResultPagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
