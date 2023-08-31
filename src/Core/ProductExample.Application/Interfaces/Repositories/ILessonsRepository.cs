using Lms.Application.Features.Lessons.Queries.GetLessonsPagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface ILessonsRepository : IRepository<Lessons>
    {
        Task<IPagedData<Lessons>> GetPagedList(GetLessonsPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
