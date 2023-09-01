using Lms.Application.Features.EventQuestions.Queries.GetEventQuestionsPagedList;
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
    public class EventQuestionsRepository : AAuditableRepository<EventQuestions, ApplicationDbContext>, IEventQuestionsRepository
    {
        public EventQuestionsRepository(ApplicationDbContext dbContext, ILogger<EventQuestions> logger) : base(dbContext, logger)
        {
        }

        public Task<IPagedData<EventQuestions>> GetPagedList(GetEventQuestionsPagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
