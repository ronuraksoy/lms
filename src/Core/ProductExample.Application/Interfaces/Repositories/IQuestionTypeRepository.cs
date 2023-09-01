using Lms.Application.Features.QuestionType.Queries.GetQuestionTypePagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface IQuestionTypeRepository:IRepository<QuestionType>
    {
        Task<IPagedData<QuestionType>> GetPagedList(GetQuestionTypePagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
