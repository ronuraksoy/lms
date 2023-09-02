using Lms.Application.Features.Customer.Queries.GetCustomerPagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        Task<IPagedData<Customer>> GetPagedList(GetCustomerPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
