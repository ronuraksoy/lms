using Lms.Application.Features.Classrooms.Queries.GetClassroomsPagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface IClassroomsRepository : IRepository<Classrooms>
    {
        Task<IPagedData<Classrooms>> GetPagedList(GetClassroomsPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
