using Lms.Application.Features.Document.Queries.GetDocumentPagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface IDocumentRepository : IRepository<Document>
    {
        Task<IPagedData<Document>> GetPagedList(GetDocumentPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
