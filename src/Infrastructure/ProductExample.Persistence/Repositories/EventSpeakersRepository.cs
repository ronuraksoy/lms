using Lms.Application.Features.EventSpeakers.Queries.GetEventSpeakersPagedList;
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
    public class EventSpeakersRepository : AAuditableRepository<EventSpeakers, ApplicationDbContext>, IEventSpeakersRepository
    {
        public EventSpeakersRepository(ApplicationDbContext dbContext, ILogger<EventSpeakers> logger) : base(dbContext, logger)
        {
        }

        public Task<IPagedData<EventSpeakers>> GetPagedList(GetEventSpeakersPagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
