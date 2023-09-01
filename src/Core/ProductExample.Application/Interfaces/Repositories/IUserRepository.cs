using Lms.Application.Features.User.Queries.GetUserPagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        Task<IPagedData<User>> GetPagedList(GetUserPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
