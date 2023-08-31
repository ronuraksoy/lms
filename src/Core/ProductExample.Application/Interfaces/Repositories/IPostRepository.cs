using Lms.Application.Features.Payment.Queries.GetPaymentPagedList;
using Lms.Application.Features.Post.Queries.GetPostPagedList;
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
    public interface IPostRepository:IRepository<Post>
    {
        Task<IPagedData<Post>> GetPagedList(GetPostPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
