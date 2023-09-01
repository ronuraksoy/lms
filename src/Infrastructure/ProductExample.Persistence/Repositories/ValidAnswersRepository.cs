using Lms.Application.Features.ValidAnswers.Queries.GetValidAnswersPagedList;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Comman.Persistence.Repositories;
using Lms.Domain.Entities;
using Lms.Persistence.Context;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Persistence.Repositories
{
    public class ValidAnswersRepository : AAuditableRepository<ValidAnswers, ApplicationDbContext>, IValidAnswersRepository
    {
        public ValidAnswersRepository(ApplicationDbContext dbContext, ILogger<ValidAnswers> logger) : base(dbContext, logger)
        {
        }

        public Task<IPagedData<ValidAnswers>> GetPagedList(GetValidAnswersPagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }
    }
}
