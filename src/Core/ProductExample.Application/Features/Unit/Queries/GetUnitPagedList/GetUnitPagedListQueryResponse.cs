using Lms.Comman.Domain.Entities;
using System;

namespace Lms.Application.Features.Unit.Queries.GetUnitPagedList
{
    public class GetUnitPagedListQueryResponse : AAuditableEntity<Guid> //Tabloda görünmesini istediğimiz bilgiler
    {
        public string Name { get; set; }
        public int Hour { get; set; }
    }
}
