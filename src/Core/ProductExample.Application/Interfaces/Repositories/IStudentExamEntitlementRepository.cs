using Lms.Application.Features.StudentExamEntitlement.Queries.GetStudentExamEntitlementPagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface IStudentExamEntitlementRepository : IRepository<StudentExamEntitlement>
    {
        Task<IPagedData<StudentExamEntitlement>> GetPagedList(GetStudentExamEntitlementPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
