using Lms.Application.Features.Classrooms.Queries.GetClassroomsPagedList;
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
    public class ClassroomsRepository : AAuditableRepository<Classrooms, ApplicationDbContext>, IClassroomsRepository
    {
        public ClassroomsRepository(ApplicationDbContext dbContext, ILogger<Classrooms> logger) : base(dbContext, logger)
        {
        }

        public Task<IPagedData<Classrooms>> GetPagedList(GetClassroomsPagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
