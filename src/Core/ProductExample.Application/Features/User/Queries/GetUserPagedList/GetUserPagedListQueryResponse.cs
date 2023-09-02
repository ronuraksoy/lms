using Lms.Comman.Domain.Entities;
using System;

namespace Lms.Application.Features.User.Queries.GetUserPagedList
{
    public class GetUserPagedListQueryResponse : AAuditableEntity<Guid> //Tabloda görünmesini istediğimiz bilgiler
    {
        public string Name { get; set; }
        public int Hour { get; set; }
    }
}
