using Lms.Application.Features.Contract.Queries.GetContractPagedList;
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
    public class ContractRepository : AAuditableRepository<Contract, ApplicationDbContext>, IContractRepository
    {
        public ContractRepository(ApplicationDbContext dbContext, ILogger<Contract> logger) : base(dbContext, logger)
        {
        }

        public Task<IPagedData<Contract>> GetPagedList(GetContractPagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
