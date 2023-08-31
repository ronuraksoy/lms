using Lms.Comman.Domain.Entities;
using System;

namespace Lms.Application.Features.StudentAssesments.Queries.GetStudentAssesmentsPagedList
{
    public class GetStudentAssesmentsPagedListQueryResponse : AAuditableEntity<Guid> //Tabloda görünmesini istediğimiz bilgiler
    {
        public string Name { get; set; }
        public int Hour { get; set; }
    }
}
