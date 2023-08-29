using Lms.Application.Features.Teacher.Queries.GetTeacherPagedList;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Comman.Persistence.Repositories;
using Lms.Domain.Entities;
using Lms.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Persistence.Repositories
{
    public class TeacherRepository : AAuditableRepository<Teacher, ApplicationDbContext>, ITeacherRepository
    {
        public TeacherRepository(ApplicationDbContext dbContext, ILogger<Teacher> logger) : base(dbContext, logger)
        {
        }

        public async Task<IPagedData<Teacher>> GetPagedList(GetTeacherPagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            var query = _dbContext.Teachers.AsQueryable();
            var totalResultCount = await query.CountAsync();
            var searchBy = model.Search?.Value;
            int searchByInt = 0;

            int.TryParse(searchBy, out searchByInt);
            if (!string.IsNullOrEmpty(searchBy))
                query = query.Where(x =>
                (x.FirstName.Contains(searchBy))
                || (x.LastName.Contains(searchBy))); // bla bla

            query = query
                .Where(x => (!string.IsNullOrEmpty(model.NameFilter) ? x.FirstName.Contains(model.NameFilter) : true));

            var filteredResultsCount = await query.CountAsync();

            var data = query
                .Include(x => x.User)
                .Skip(model.Start)
                .Take(model.Length).AsEnumerable();

            return new PagedData<Teacher>(totalResultCount, filteredResultsCount, data);
        }
    }
}
