using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Persistence.Repositories;
using Lms.Domain.Entities;
using Lms.Persistence.Context;
using Microsoft.Extensions.Logging;

namespace Lms.Persistence.Repositories
{
    public class ValidAnswersRepository : AAuditableRepository<ValidAnswers, ApplicationDbContext>, IValidAnswersRepository
    {
        public ValidAnswersRepository(ApplicationDbContext dbContext, ILogger<ValidAnswers> logger) : base(dbContext, logger)
        {
        }
    }
}
