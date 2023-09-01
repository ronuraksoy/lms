using Lms.Application.Features.BookRecommendations.Queries.GetBookRecommendationsPagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface IBookRecommendationsRepository : IRepository<BookRecommendations>
    {
        Task<IPagedData<BookRecommendations>> GetPagedList(GetBookRecommendationsPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
