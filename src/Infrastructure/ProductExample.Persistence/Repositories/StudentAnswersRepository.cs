using Lms.Application.Features.StudentAnswers.Queries.GetStudentAnswersPagedList;
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
    public class StudentAnswersRepository : AAuditableRepository<StudentAnswers, ApplicationDbContext>, IStudentAnswersRepository
    {
        public StudentAnswersRepository(ApplicationDbContext dbContext, ILogger<StudentAnswers> logger) : base(dbContext, logger)
        {
        }

        public Task<IPagedData<StudentAnswers>> GetPagedList(GetStudentAnswersPagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }
    }
}