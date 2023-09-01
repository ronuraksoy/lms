using Lms.Application.Features.StudentAssignments.Queries.GetStudentAssignmentsPagedList;
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
    public class StudentAssignmentsRepository : AAuditableRepository<StudentAssignments, ApplicationDbContext>, IStudentAssignmentsRepository
    {
        public StudentAssignmentsRepository(ApplicationDbContext dbContext, ILogger<StudentAssignments> logger) : base(dbContext, logger)
        {
        }

        public Task<IPagedData<StudentAssignments>> GetPagedList(GetStudentAssignmentsPagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }
    }
}