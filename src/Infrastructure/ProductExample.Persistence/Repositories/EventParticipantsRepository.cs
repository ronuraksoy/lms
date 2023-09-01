using Lms.Application.Features.EventParticipants.Queries.GetEventParticipantsPagedList;
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
    public class EventParticipantsRepository : AAuditableRepository<EventParticipants, ApplicationDbContext>, IEventParticipantsRepository
    {
        public EventParticipantsRepository(ApplicationDbContext dbContext, ILogger<EventParticipants> logger) : base(dbContext, logger)
        {
        }

        public Task<IPagedData<EventParticipants>> GetPagedList(GetEventParticipantsPagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
