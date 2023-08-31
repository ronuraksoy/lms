using Lms.Application.Features.Payment.Queries.GetPaymentPagedList;
using Lms.Application.Features.Product.Queries.GetProductPagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<IPagedData<Product>> GetPagedList(GetProductPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}