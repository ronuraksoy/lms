using Lms.Comman.Domain.Entities;
using System;

namespace Lms.Application.Features.Teacher.Queries.GetTeacherPagedList
{
    public class GetTeacherPagedListQueryResponse : AAuditableEntity<Guid> //Tabloda görünmesini istediğimiz bilgiler
    {
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
