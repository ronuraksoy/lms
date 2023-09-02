using Lms.Application.Features.Chat.Queries.GetChatPagedList;
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
    public class ChatRepository : AAuditableRepository<Chat, ApplicationDbContext>, IChatRepository
    {
        public ChatRepository(ApplicationDbContext dbContext, ILogger<Chat> logger) : base(dbContext, logger)
        {
        }

        public Task<IPagedData<Chat>> GetPagedList(GetChatPagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
