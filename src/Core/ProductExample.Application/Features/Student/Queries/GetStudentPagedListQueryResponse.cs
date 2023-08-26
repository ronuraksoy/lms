using Lms.Common.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.Student.Queries
{
    public class GetStudentPagedListQueryResponse : AAuditableEntity<Guid> //Tabloda görünmesini istediğimiz bilgiler
    {
        public Guid UserId { get; set; }
        public string? School { get; set; }
        public string? Grade { get; set; }
    }
}
