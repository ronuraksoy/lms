using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Common.Application.UnitOfWork
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
