using Lms.Application.Features.Chat.Queries.GetChatPagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface IChatRepository : IRepository<Chat>
    {
        Task<IPagedData<Chat>> GetPagedList(GetChatPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
