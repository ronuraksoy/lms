using Lms.Application.Features.ContactMessage.Queries.GetContactMessagePagedList;
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
    public class ContactMessageRepository : AAuditableRepository<ContactMessage, ApplicationDbContext>, IContactMessageRepository
    {
        public ContactMessageRepository(ApplicationDbContext dbContext, ILogger<ContactMessage> logger) : base(dbContext, logger)
        {
        }

        public Task<IPagedData<ContactMessage>> GetPagedList(GetContactMessagePagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
