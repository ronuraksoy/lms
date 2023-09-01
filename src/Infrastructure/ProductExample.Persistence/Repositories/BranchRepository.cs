using Lms.Application.Features.Branch.Queries.GetBranchPagedList;
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
    public class BranchRepository : AAuditableRepository<Branch, ApplicationDbContext>, IBranchRepository
    {
        public BranchRepository(ApplicationDbContext dbContext, ILogger<Branch> logger) : base(dbContext, logger)
        {
        }

        public Task<IPagedData<Branch>> GetPagedList(GetBranchPagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
