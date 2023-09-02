using Lms.Application.Features.CurriculumLesson.Queries.GetCurriculumLessonPagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface ICurriculumLessonRepository : IRepository<CurriculumLesson>
    {
        Task<IPagedData<CurriculumLesson>> GetPagedList(GetCurriculumLessonPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
