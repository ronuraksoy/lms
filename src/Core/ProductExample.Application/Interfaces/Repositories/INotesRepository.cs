using Lms.Application.Features.Notes.Queries.GetNotesPagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface INotesRepository:IRepository<Notes>
    {
        Task<IPagedData<Notes>> GetPagedList(GetNotesPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
