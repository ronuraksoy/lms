using Lms.Application.Features.Student.Queries.GetStudentPagedList;
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
    public class StudentRepository : AAuditableRepository<Student, ApplicationDbContext>, IStudentRepository
    {
        public StudentRepository(ApplicationDbContext dbContext, ILogger<Student> logger) : base(dbContext, logger)
        {
        }

        public Task<IPagedData<Student>> GetPagedList(GetStudentPagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }
    }
}