using Lms.Comman.Domain.Entities;
using System;

namespace Lms.Application.Features.StudentAssignments.Queries.GetStudentAssignmentsPagedList
{
    public class GetStudentAssignmentsPagedListQueryResponse : AAuditableEntity<Guid> //Tabloda görünmesini istediğimiz bilgiler
    {
        public string Name { get; set; }
        public int Hour { get; set; }
    }
}
