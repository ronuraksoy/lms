using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading.Tasks;
using System.Threading;
using Lms.Application.Features.AnnouncementStudent.Queries.GetAnnouncementStudentPagedList;

namespace Lms.Application.Interfaces.Repositories
{
    public interface IAnnouncementStudentRepository : IRepository<AnnouncementStudent>
    {
        Task<IPagedData<AnnouncementStudent>> GetPagedList(GetAnnouncementStudentPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
