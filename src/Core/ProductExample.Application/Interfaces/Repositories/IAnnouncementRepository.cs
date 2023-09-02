using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading.Tasks;
using System.Threading;
using Lms.Application.Features.Announcement.Queries.GetAnnouncementPagedList;

namespace Lms.Application.Interfaces.Repositories
{
    public interface IAnnouncementRepository : IRepository<Announcement>
    {
        Task<IPagedData<Announcement>> GetPagedList(GetAnnouncementPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
