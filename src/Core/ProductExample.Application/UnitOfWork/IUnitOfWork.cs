using System;
using System.Threading;
using System.Threading.Tasks;

namespace Rys.Common.Application.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        int SaveChanges();
        Task<int> SaveChangesAsync();
        Task BeginWritingAsync(CancellationToken cancellationToken);
        Task CommitWritingsAsync(CancellationToken cancellationToken);
        Task DiscardWritingsAsync(CancellationToken cancellationToken);
        /// <summary>
        /// True ise transaction başlatılmış, false ise transaction başlatılmamıştır.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        bool HasTransaction();

    }
}
