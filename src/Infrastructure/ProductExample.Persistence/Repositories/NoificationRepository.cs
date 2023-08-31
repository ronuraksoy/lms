using Lms.Application.Features.Notification.Queries.GetNotificationPagedList;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Comman.Persistence.Repositories;
using Lms.Domain.Entities;
using Lms.Persistence.Context;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Persistence.Repositories
{
    internal class NoificationRepository : AAuditableRepository<Notification, ApplicationDbContext>, INotificationRepository
    {
        public NoificationRepository(ApplicationDbContext dbContext, ILogger<Notification> logger) : base(dbContext, logger)
        {
        }

        public Task<IPagedData<Notification>> GetPagedList(GetNotificationPagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
