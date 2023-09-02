using Lms.Application.Features.Contract.Queries.GetContractPagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface IContractRepository : IRepository<Contract>
    {
        Task<IPagedData<Contract>> GetPagedList(GetContractPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
