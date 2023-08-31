using Lms.Application.Features.Payment.Queries.GetPaymentPagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface IPaymentRepository:IRepository<Payment>
    {
        Task<IPagedData<Payment>> GetPagedList(GetPaymentPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
