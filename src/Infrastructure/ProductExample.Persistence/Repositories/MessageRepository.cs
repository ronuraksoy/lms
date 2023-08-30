using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Persistence.Repositories;
using Lms.Domain.Entities;
using Lms.Persistence.Context;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Persistence.Repositories
{
    public class MessageRepository : AAuditableRepository<Message, ApplicationDbContext>, IMessageRepository
    {
        public MessageRepository(ApplicationDbContext dbContext, ILogger<Message> logger) : base(dbContext, logger)
        {
        }
    }
}
