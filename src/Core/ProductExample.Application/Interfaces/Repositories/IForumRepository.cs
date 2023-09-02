using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading.Tasks;
using System.Threading;
using Lms.Application.Features.Forum.Queries.GetForumPagedList;

namespace Lms.Application.Interfaces.Repositories
{
    public interface IForumRepository : IRepository<Forum>
    {
        Task<IPagedData<Forum>> GetPagedList(GetForumPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
