using Lms.Application.Features.Semester.Queries.GetSemesterPagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface ISemesterRepository : IRepository<Semester>
    {
        Task<IPagedData<Semester>> GetPagedList(GetSemesterPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
