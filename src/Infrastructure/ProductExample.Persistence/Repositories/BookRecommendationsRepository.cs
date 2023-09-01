using Lms.Application.Features.BookRecommendations.Queries.GetBookRecommendationsPagedList;
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
    public class BookRecommendationsRepository : AAuditableRepository<BookRecommendations, ApplicationDbContext>, IBookRecommendationsRepository
    {
        public BookRecommendationsRepository(ApplicationDbContext dbContext, ILogger<BookRecommendations> logger) : base(dbContext, logger)
        {
        }

        public Task<IPagedData<BookRecommendations>> GetPagedList(GetBookRecommendationsPagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
