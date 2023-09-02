using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading.Tasks;
using System.Threading;
using Lms.Application.Features.Faculty.Queries.GetFacultyPagedList;

namespace Lms.Application.Interfaces.Repositories
{
    public interface IFacultyRepository : IRepository<Faculty>
    {
        Task<IPagedData<Faculty>> GetPagedList(GetFacultyPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
