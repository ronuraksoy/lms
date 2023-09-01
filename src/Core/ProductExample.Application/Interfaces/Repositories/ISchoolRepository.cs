using Lms.Application.Features.School.Queries.GetSchoolPagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface ISchoolRepository: IRepository<School>
    {
        Task<IPagedData<School>> GetPagedList(GetSchoolPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
