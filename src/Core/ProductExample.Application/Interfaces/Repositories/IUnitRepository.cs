using Lms.Application.Features.Unit.Queries.GetUnitPagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface IUnitRepository : IRepository<Unit>
    {
        Task<IPagedData<Unit>> GetPagedList(GetUnitPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
