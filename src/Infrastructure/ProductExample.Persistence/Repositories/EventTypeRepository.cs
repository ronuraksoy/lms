using Lms.Application.Features.EventType.Queries.GetEventTypePagedList;
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
    public class EventTypeRepository : AAuditableRepository<EventType, ApplicationDbContext>, IEventTypeRepository
    {
        public EventTypeRepository(ApplicationDbContext dbContext, ILogger<EventType> logger) : base(dbContext, logger)
        {
        }

        public Task<IPagedData<EventType>> GetPagedList(GetEventTypePagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
