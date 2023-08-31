using Lms.Application.Features.Notification.Queries.GetNotificationPagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface INotificationRepository : IRepository<Notification>
    {
        Task<IPagedData<Notification>> GetPagedList(GetNotificationPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
