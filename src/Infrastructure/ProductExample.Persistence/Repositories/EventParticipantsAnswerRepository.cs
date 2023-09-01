using Lms.Application.Features.EventParticipantsAnswer.Queries.GetEventParticipantsAnswerPagedList;
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
    public class EventParticipantsAnswerRepository : AAuditableRepository<EventParticipantsAnswer, ApplicationDbContext>, IEventParticipantsAnswerRepository
    {
        public EventParticipantsAnswerRepository(ApplicationDbContext dbContext, ILogger<EventParticipantsAnswer> logger) : base(dbContext, logger)
        {
        }

        public Task<IPagedData<EventParticipantsAnswer>> GetPagedList(GetEventParticipantsAnswerPagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
