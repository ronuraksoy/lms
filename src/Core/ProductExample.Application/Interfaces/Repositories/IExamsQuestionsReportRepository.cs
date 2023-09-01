using Lms.Application.Features.ExamsQuestionsReport.Queries.GetExamsQuestionsReportPagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface IExamsQuestionsReportRepository : IRepository<ExamsQuestionsReport>
    {
        Task<IPagedData<ExamsQuestionsReport>> GetPagedList(GetExamsQuestionsPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
