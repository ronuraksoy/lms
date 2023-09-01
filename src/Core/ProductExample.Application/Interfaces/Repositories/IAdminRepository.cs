using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading.Tasks;
using System.Threading;
using Lms.Application.Features.Admin.Queries.GetAdminPagedList;

namespace Lms.Application.Interfaces.Repositories
{
    public interface IAdminRepository : IRepository<Admin>
    {
        Task<IPagedData<Admin>> GetPagedList(GetAdminPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
