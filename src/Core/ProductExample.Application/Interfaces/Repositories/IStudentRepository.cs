using Lms.Application.Features.Student.Queries.GetStudentPagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface IStudentRepository : IRepository<Student>
    {
        Task<IPagedData<Student>> GetPagedList(GetStudentPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}