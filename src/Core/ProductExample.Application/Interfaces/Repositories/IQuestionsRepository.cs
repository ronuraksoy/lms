using Lms.Application.Features.Questions.Queries.GetQuestionPagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface IQuestionsRepository:IRepository<Questions>
    {
        Task<IPagedData<Questions>> GetPagedList(GetQuestionsPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
