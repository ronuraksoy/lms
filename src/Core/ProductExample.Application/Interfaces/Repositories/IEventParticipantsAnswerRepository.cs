using Lms.Application.Features.EventParticipantsAnswer.Queries.GetEventParticipantsAnswerPagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface IEventParticipantsAnswerRepository : IRepository<EventParticipantsAnswer>
    {
        Task<IPagedData<EventParticipantsAnswer>> GetPagedList(GetEventParticipantsAnswerPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
