using Lms.Application.Features.EventQuestions.Queries.GetEventQuestionsPagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface IEventQuestionsRepository : IRepository<EventQuestions>
    {
        Task<IPagedData<EventQuestions>> GetPagedList(GetEventQuestionsPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
