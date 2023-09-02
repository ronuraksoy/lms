using Lms.Application.Features.Comment.Queries.GetCommentPagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface ICommentRepository : IRepository<Comment>
    {
        Task<IPagedData<Comment>> GetPagedList(GetCommentPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
