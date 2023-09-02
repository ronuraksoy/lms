using Lms.Application.Features.Curriculum.Queries.GetCurriculumPagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface ICurriculumRepository : IRepository<Curriculum>
    {
        Task<IPagedData<Curriculum>> GetPagedList(GetCurriculumPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
