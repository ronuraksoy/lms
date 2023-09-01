using Lms.Application.Features.Events.Queries.GetEventsPagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface IEventsRepository : IRepository<Events>
    {
        Task<IPagedData<Events>> GetPagedList(GetEventsPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
