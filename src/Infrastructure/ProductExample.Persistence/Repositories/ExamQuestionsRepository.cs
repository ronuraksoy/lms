using Lms.Application.Features.ExamsQuestions.Queries.GetExamsQuestionsPagedList;
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
    public class ExamsQuestionsRepository : AAuditableRepository<ExamsQuestions, ApplicationDbContext>, IExamsQuestionsRepository
    {
        public ExamsQuestionsRepository(ApplicationDbContext dbContext, ILogger<ExamsQuestions> logger) : base(dbContext, logger)
        {
        }

        public Task<IPagedData<ExamsQuestions>> GetPagedList(GetExamsQuestionsPagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
