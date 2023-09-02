using Lms.Comman.Domain.Entities;
using System;

namespace Lms.Application.Features.Semester.Queries.GetSemesterPagedList
{
    public class GetSemesterPagedListQueryResponse : AAuditableEntity<Guid> //Tabloda görünmesini istediğimiz bilgiler
    {
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
