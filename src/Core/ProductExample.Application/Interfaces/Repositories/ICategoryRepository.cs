using Lms.Application.Features.Teacher.Queries.GetTeacherPagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading.Tasks;
using System.Threading;
using Lms.Application.Features.Category.Queries.GetCategoryPagedList;

namespace Lms.Application.Interfaces.Repositories
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Task<IPagedData<Category>> GetPagedList(GetCategoryPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
