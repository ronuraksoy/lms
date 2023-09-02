using Lms.Application.Features.Curriculum.Queries.GetCurriculumPagedList;
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
    public class CurriculumRepository : AAuditableRepository<Curriculum, ApplicationDbContext>, ICurriculumRepository
    {
        public CurriculumRepository(ApplicationDbContext dbContext, ILogger<Curriculum> logger) : base(dbContext, logger)
        {
        }

        public Task<IPagedData<Curriculum>> GetPagedList(GetCurriculumPagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
