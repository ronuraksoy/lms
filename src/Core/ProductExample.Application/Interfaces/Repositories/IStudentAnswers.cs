using Lms.Application.Features.StudentAnswers.Queries.GetStudentAnswersPagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface IStudentAnswersRepository : IRepository<StudentAnswers>
    {
        Task<IPagedData<StudentAnswers>> GetPagedList(GetStudentAnswersPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
