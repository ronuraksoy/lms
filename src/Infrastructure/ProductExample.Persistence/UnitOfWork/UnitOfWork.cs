using Microsoft.EntityFrameworkCore.Storage;
using Lms.Application.Interfaces.Repositories;
using Lms.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lms.Common.Application.UnitOfWork;
using System.Threading;

namespace Lms.Persistence.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly ApplicationDbContext _applicationDbContext;
        public UnitOfWork(
            ApplicationDbContext applicationDbContext,
            IProductRepository productRepository,
            IOrderRepository orderRepository)
        {
            _applicationDbContext = applicationDbContext;
            ProductRepository = productRepository;
            OrderRepository = orderRepository;
        }

        public IProductRepository ProductRepository { get; }
        public IOrderRepository OrderRepository { get; }

        public async Task<IDbContextTransaction> BeginTransactionAsync()
        {
            return await _applicationDbContext.Database.BeginTransactionAsync();
        }

        public Task BeginWritingAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task CommitWritingsAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task DiscardWritingsAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool HasTransaction()
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
