using Lms.Application.Features.Educations.Queries.GetEducationsPagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface IEducationsRepository : IRepository<Educations>
    {
        Task<IPagedData<Educations>> GetPagedList(GetEducationsPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
