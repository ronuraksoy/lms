using Lms.Application.Features.StudentQuestions.Queries.GetStudentQuestionsPagedList;
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
    public class StudentQuestionsRepository : AAuditableRepository<StudentQuestions, ApplicationDbContext>, IStudentQuestionsRepository
    {
        public StudentQuestionsRepository(ApplicationDbContext dbContext, ILogger<StudentQuestions> logger) : base(dbContext, logger)
        {
        }

        public Task<IPagedData<StudentQuestions>> GetPagedList(GetStudentQuestionsPagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }
    }
}
