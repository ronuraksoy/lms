using Lms.Application.Features.QuestionCategory.Queries.GetQuestionCategoryPagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface IQuestionCategoryRepository : IRepository<QuestionCategory>
    {
        Task<IPagedData<QuestionCategory>> GetPagedList(GetQuestionCategoryPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
