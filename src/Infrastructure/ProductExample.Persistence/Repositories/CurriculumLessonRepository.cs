using Lms.Application.Features.CurriculumLesson.Queries.GetCurriculumLessonPagedList;
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
    public class CurriculumLessonRepository : AAuditableRepository<CurriculumLesson, ApplicationDbContext>, ICurriculumLessonRepository
    {
        public CurriculumLessonRepository(ApplicationDbContext dbContext, ILogger<CurriculumLesson> logger) : base(dbContext, logger)
        {
        }

        public Task<IPagedData<CurriculumLesson>> GetPagedList(GetCurriculumLessonPagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
