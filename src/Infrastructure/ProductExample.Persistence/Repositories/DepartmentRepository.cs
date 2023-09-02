using Lms.Application.Features.Department.Queries.GetDepartmentPagedList;
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
    public class DepartmentRepository : AAuditableRepository<Department, ApplicationDbContext>, IDepartmentRepository
    {
        public DepartmentRepository(ApplicationDbContext dbContext, ILogger<Department> logger) : base(dbContext, logger)
        {
        }

        public Task<IPagedData<Department>> GetPagedList(GetDepartmentPagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
