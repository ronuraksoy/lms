using Lms.Application.Features.Message.Queries.GetMessagePagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface IMessageRepository:IRepository<Message>
    {
        Task<IPagedData<Message>> GetPagedList(GetMessagePagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
