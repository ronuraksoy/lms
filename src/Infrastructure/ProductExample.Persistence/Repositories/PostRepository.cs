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
    public class PostRepository : AAuditableRepository<Post, ApplicationDbContext>, IPostRepository
    {
        public PostRepository(ApplicationDbContext dbContext, ILogger<Post> logger) : base(dbContext, logger)
        {
        }
    }
}
