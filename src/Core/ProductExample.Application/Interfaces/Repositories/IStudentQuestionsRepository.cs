using Lms.Application.Features.StudentQuestions.Queries.GetStudentQuestionsPagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface IStudentQuestionsRepository : IRepository<StudentQuestions>
    {
        Task<IPagedData<StudentQuestions>> GetPagedList(GetStudentQuestionsPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
