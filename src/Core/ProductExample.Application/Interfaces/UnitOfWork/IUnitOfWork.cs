using Microsoft.EntityFrameworkCore.Storage;
using Lms.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.UnitOfWork
{
    public interface IUnitOfWork
    {
        Task<IDbContextTransaction> BeginTransactionAsync();
        IProductRepository ProductRepository { get; }
        IOrderRepository OrderRepository { get; }
    }
}
