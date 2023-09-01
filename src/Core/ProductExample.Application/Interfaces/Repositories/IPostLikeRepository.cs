using Lms.Application.Features.PostLike.Queries.GetPostLikePagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface IPostLikeRepository:IRepository<PostLike>
    {
        Task<IPagedData<PostLike>> GetPagedList(GetPostLikePagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
