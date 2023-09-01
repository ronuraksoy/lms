using Lms.Comman.Domain.Entities;
using System;

namespace Lms.Application.Features.Student.Queries.GetStudentPagedList
{
    public class GetStudentPagedListQueryResponse : AAuditableEntity<Guid> //Tabloda görünmesini istediğimiz bilgiler
    {
        public string Name { get; set; }
        public int Hour { get; set; }
    }
}
