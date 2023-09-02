using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading.Tasks;
using System.Threading;
using Lms.Application.Features.ForumContent.Queries.GetForumContentPagedList;

namespace Lms.Application.Interfaces.Repositories
{
    public interface IForumContentRepository : IRepository<ForumContent>
    {
        Task<IPagedData<ForumContent>> GetPagedList(GetForumContentPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
