using Lms.Application.Features.Comment.Queries.GetCommentPagedList;
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
    public class CommentRepository : AAuditableRepository<Comment, ApplicationDbContext>, ICommentRepository
    {
        public CommentRepository(ApplicationDbContext dbContext, ILogger<Comment> logger) : base(dbContext, logger)
        {
        }

        public Task<IPagedData<Comment>> GetPagedList(GetCommentPagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
