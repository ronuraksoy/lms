using Lms.Application.Features.ValidAnswers.Queries.GetValidAnswersPagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface IValidAnswersRepository : IRepository<ValidAnswers>
    {
        Task<IPagedData<ValidAnswers>> GetPagedList(GetValidAnswersPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
