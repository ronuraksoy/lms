using Lms.Application.Features.PostLike.Queries.GetPostLikePagedList;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Comman.Persistence.Repositories;
using Lms.Domain.Entities;
using Lms.Persistence.Context;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Persistence.Repositories
{
    public class PostLikeRepository : AAuditableRepository<PostLike, ApplicationDbContext>, IPostLikeRepository
    {
        public PostLikeRepository(ApplicationDbContext dbContext, ILogger<PostLike> logger) : base(dbContext, logger)
        {
        }

        public Task<IPagedData<PostLike>> GetPagedList(GetPostLikePagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
