using Lms.Application.Features.AssignmentResult.Queries.GetAssignmentResultPagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface IAssignmentResultRepository : IRepository<AssignmentResult>
    {
        Task<IPagedData<AssignmentResult>> GetPagedList(GetAssignmentResultPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
