using Lms.Application.Features.ExamsQuestions.Queries.GetExamsQuestionsPagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface IExamsQuestionsRepository : IRepository<ExamsQuestions>
    {
        Task<IPagedData<ExamsQuestions>> GetPagedList(GetExamsQuestionsPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
