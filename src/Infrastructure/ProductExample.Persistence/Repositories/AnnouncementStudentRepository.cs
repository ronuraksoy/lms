using Lms.Application.Features.AnnouncementStudent.Queries.GetAnnouncementStudentPagedList;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Comman.Persistence.Repositories;
using Lms.Domain.Entities;
using Lms.Persistence.Context;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Persistence.Repositories
{
    public class AnnouncementStudentRepository : AAuditableRepository<AnnouncementStudent, ApplicationDbContext>, IAnnouncementStudentRepository
    {
        public AnnouncementStudentRepository(ApplicationDbContext dbContext, ILogger<AnnouncementStudent> logger) : base(dbContext, logger)
        {
        }

        public Task<IPagedData<AnnouncementStudent>> GetPagedList(GetAnnouncementStudentPagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }
    }
}
