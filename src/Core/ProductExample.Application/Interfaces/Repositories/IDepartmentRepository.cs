using Lms.Application.Features.Department.Queries.GetDepartmentPagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface IDepartmentRepository : IRepository<Department>
    {
        Task<IPagedData<Department>> GetPagedList(GetDepartmentPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
