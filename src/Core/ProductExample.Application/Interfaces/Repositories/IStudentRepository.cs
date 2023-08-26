using Lms.Application.Features.Student.Queries;
using Lms.Common.Application.Repositories;
using Lms.Common.Domain.Entities;
using Lms.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface IStudentRepository : IRepository<Student>
    {
        Task<IPagedData<Student>> GetPagedList(GetStudentPagedListQueryRequest model);
    }
}
