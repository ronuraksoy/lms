﻿using Lms.Application.Features.StudentExamEntitlement.Queries.GetStudentExamEntitlementPagedList;
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
    public class StudentExamEntitlementRepository : AAuditableRepository<StudentExamEntitlement, ApplicationDbContext>, IStudentExamEntitlementRepository
    {
        public StudentExamEntitlementRepository(ApplicationDbContext dbContext, ILogger<StudentExamEntitlement> logger) : base(dbContext, logger)
        {
        }

        public Task<IPagedData<StudentExamEntitlement>> GetPagedList(GetStudentExamEntitlementPagedListQueryRequest model, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }
    }
}