using Lms.Application.Features.Order.Queries.GetOrderPagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {
        Task<IPagedData<Order>> GetPagedList(GetOrderPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
