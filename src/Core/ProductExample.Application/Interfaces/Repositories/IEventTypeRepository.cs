using Lms.Application.Features.EventType.Queries.GetEventTypePagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface IEventTypeRepository : IRepository<EventType>
    {
        Task<IPagedData<EventType>> GetPagedList(GetEventTypePagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
