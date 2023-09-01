using Lms.Comman.Domain.Entities;
using System;

namespace Lms.Application.Features.StudentQuestions.Queries.GetStudentQuestionsPagedList
{
    public class GetStudentQuestionsPagedListQueryResponse : AAuditableEntity<Guid> //Tabloda görünmesini istediğimiz bilgiler
    {
        public string Name { get; set; }
        public int Hour { get; set; }
    }
}
