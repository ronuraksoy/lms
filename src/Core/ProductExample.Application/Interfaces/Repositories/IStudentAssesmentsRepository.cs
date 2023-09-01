using Lms.Application.Features.StudentAssesments.Queries.GetStudentAssesmentsPagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface IStudentAssesmentsRepository : IRepository<StudentAssesments>
    {
        Task<IPagedData<StudentAssesments>> GetPagedList(GetStudentAssesmentsPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
