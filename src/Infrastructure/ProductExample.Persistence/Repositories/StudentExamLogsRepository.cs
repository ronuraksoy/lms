using Lms.Application.Features.StudentExamLogs.Queries.GetStudentExamLogsPagedList;
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
    public class StudentExamLogsRepository : AAuditableRepository<StudentExamLogs, ApplicationDbContext>, IStudentExamLogsRepository
    {
        public StudentExamLogsRepository(ApplicationDbContext dbContext, ILogger<StudentExamLogs> logger) : base(dbContext, logger)
        {
        }

        public Task<IPagedData<StudentExamLogs>> GetPagedList(GetStudentExamLogsPagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }
    }
}