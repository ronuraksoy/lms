using Lms.Application.Features.Exams.Queries.GetExamsPagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface IExamsRepository : IRepository<Exams>
    {
        Task<IPagedData<Exams>> GetPagedList(GetExamsPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
