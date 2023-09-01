using Lms.Application.Features.QuestionType.Queries.GetQuestionTypePagedList;
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
    public class QuestionTypeRepository : AAuditableRepository<QuestionType, ApplicationDbContext>, IQuestionTypeRepository
    {
        public QuestionTypeRepository(ApplicationDbContext dbContext, ILogger<QuestionType> logger) : base(dbContext, logger)
        {
        }

        public Task<IPagedData<QuestionType>> GetPagedList(GetQuestionTypePagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
