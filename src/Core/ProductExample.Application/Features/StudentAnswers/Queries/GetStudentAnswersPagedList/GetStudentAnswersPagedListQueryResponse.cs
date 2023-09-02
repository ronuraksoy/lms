using Lms.Comman.Domain.Entities;
using System;

namespace Lms.Application.Features.StudentAnswers.Queries.GetStudentAnswersPagedList
{
    public class GetStudentAnswersPagedListQueryResponse : AAuditableEntity<Guid> //Tabloda görünmesini istediğimiz bilgiler
    {
        public string Name { get; set; }
        public int Hour { get; set; }
    }
}
