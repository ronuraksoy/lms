using Lms.Application.Features.Educations.Queries.GetEducationsPagedList;
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
    public class EducationsRepository : AAuditableRepository<Educations, ApplicationDbContext>, IEducationsRepository
    {
        public EducationsRepository(ApplicationDbContext dbContext, ILogger<Educations> logger) : base(dbContext, logger)
        {
        }

        public Task<IPagedData<Educations>> GetPagedList(GetEducationsPagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
