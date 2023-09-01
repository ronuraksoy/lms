using Lms.Application.Features.StudentAssignments.Queries.GetStudentAssignmentsPagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface IStudentAssignmentsRepository : IRepository<StudentAssignments>
    {
        Task<IPagedData<StudentAssignments>> GetPagedList(GetStudentAssignmentsPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
