using Lms.Application.Features.Branch.Queries.GetBranchPagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface IBranchRepository : IRepository<Branch>
    {
        Task<IPagedData<Branch>> GetPagedList(GetBranchPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
