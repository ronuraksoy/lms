using Lms.Application.Features.Events.Queries.GetEventsPagedList;
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
    public class EventsRepository : AAuditableRepository<Events, ApplicationDbContext>, IEventsRepository
    {
        public EventsRepository(ApplicationDbContext dbContext, ILogger<Events> logger) : base(dbContext, logger)
        {
        }

        public Task<IPagedData<Events>> GetPagedList(GetEventsPagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
