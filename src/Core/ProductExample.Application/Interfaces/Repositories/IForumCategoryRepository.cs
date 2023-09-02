using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading.Tasks;
using System.Threading;
using Lms.Application.Features.ForumCategory.Queries.GetForumCategoryPagedList;

namespace Lms.Application.Interfaces.Repositories
{
    public interface IForumCategoryRepository : IRepository<ForumCategory>
    {
        Task<IPagedData<ForumCategory>> GetPagedList(GetForumCategoryPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
