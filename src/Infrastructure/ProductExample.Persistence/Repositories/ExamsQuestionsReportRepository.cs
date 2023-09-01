using Lms.Application.Features.ExamsQuestionsReport.Queries.GetExamsQuestionsReportPagedList;
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
    public class ExamsQuestionsReportRepository : AAuditableRepository<ExamsQuestionsReport, ApplicationDbContext>, IExamsQuestionsReportRepository
    {
        public ExamsQuestionsReportRepository(ApplicationDbContext dbContext, ILogger<ExamsQuestionsReport> logger) : base(dbContext, logger)
        {
        }

        public Task<IPagedData<ExamsQuestionsReport>> GetPagedList(GetExamsQuestionsPagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
