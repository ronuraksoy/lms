using Lms.Application.Features.EducationAssignments.Queries.GetEducationAssignmentsPagedList;
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
    public class EducationAssignmentsRepository : AAuditableRepository<EducationAssignments, ApplicationDbContext>, IEducationAssignmentsRepository
    {
        public EducationAssignmentsRepository(ApplicationDbContext dbContext, ILogger<EducationAssignments> logger) : base(dbContext, logger)
        {
        }

        public Task<IPagedData<EducationAssignments>> GetPagedList(GetEducationAssignmentsPagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
