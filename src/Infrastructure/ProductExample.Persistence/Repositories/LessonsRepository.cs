using Lms.Application.Features.Lessons.Queries.GetLessonsPagedList;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Comman.Persistence.Repositories;
using Lms.Domain.Entities;
using Lms.Persistence.Context;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Persistence.Repositories
{
    public class LessonsRepository: AAuditableRepository<Lessons, ApplicationDbContext>, ILessonsRepository
    {
        public LessonsRepository(ApplicationDbContext dbContext, ILogger<Lessons> logger) : base(dbContext, logger)
        {
        }

        public Task<IPagedData<Lessons>> GetPagedList(GetLessonsPagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
