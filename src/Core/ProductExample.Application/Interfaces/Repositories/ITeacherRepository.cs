using Lms.Application.Features.Teacher.Queries;
using Lms.Common.Application.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lms.Application.Features.Teacher.Queries.GetTeacherPagedList;
using System.Threading;

namespace Lms.Application.Interfaces.Repositories
{
    public interface ITeacherRepository : IRepository<Teacher>
    {
        Task<IPagedData<Teacher>> GetPagedList(GetTeacherPagedListQueryRequest model, CancellationToken cancellationToken = default);
    }
}
