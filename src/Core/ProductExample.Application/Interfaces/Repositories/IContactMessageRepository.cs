using Lms.Application.Features.ContactMessage.Queries.GetContactMessagePagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface IContactMessageRepository : IRepository<ContactMessage>
    {
        Task<IPagedData<ContactMessage>> GetPagedList(GetContactMessagePagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
