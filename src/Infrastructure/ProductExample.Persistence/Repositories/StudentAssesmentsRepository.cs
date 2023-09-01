using Lms.Application.Features.StudentAssesments.Queries.GetStudentAssesmentsPagedList;
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
    public class StudentAssesmentsRepository : AAuditableRepository<StudentAssesments, ApplicationDbContext>, IStudentAssesmentsRepository
    {
        public StudentAssesmentsRepository(ApplicationDbContext dbContext, ILogger<StudentAssesments> logger) : base(dbContext, logger)
        {
        }

        public Task<IPagedData<StudentAssesments>> GetPagedList(GetStudentAssesmentsPagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }
    }
}
