using Lms.Application.Features.EducationAssignments.Queries.GetEducationAssignmentsPagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface IEducationAssignmentsRepository : IRepository<EducationAssignments>
    {
        Task<IPagedData<EducationAssignments>> GetPagedList(GetEducationAssignmentsPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
