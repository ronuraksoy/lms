using Lms.Comman.Domain.Entities;
using System;

namespace Lms.Application.Features.StudentExamEntitlement.Queries.GetStudentExamEntitlementPagedList
{
    public class GetStudentExamEntitlementPagedListQueryResponse : AAuditableEntity<Guid> //Tabloda görünmesini istediğimiz bilgiler
    {
        public string Name { get; set; }
        public int Hour { get; set; }
    }
}
