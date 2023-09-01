using Lms.Application.Features.StudentExamLogs.Queries.GetStudentExamLogsPagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface IStudentExamLogsRepository : IRepository<StudentExamLogs>
    {
        Task<IPagedData<StudentExamLogs>> GetPagedList(GetStudentExamLogsPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
