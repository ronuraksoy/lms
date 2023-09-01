using Lms.Application.Features.EventParticipants.Queries.GetEventParticipantsPagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface IEventParticipantsRepository : IRepository<EventParticipants>
    {
        Task<IPagedData<EventParticipants>> GetPagedList(GetEventParticipantsPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
