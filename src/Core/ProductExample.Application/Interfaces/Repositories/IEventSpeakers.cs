using Lms.Application.Features.EventSpeakers.Queries.GetEventSpeakersPagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface IEventSpeakersRepository : IRepository<EventSpeakers>
    {
        Task<IPagedData<EventSpeakers>> GetPagedList(GetEventSpeakersPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
