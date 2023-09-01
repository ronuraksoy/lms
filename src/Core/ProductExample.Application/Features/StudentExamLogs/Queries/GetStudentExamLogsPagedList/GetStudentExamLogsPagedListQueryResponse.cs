using Lms.Comman.Domain.Entities;
using System;

namespace Lms.Application.Features.StudentExamLogs.Queries.GetStudentExamLogsPagedList
{
    public class GetStudentExamLogsPagedListQueryResponse : AAuditableEntity<Guid> //Tabloda görünmesini istediğimiz bilgiler
    {
        public string Name { get; set; }
        public int Hour { get; set; }
    }
}
