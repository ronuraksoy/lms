using Lms.Comman.Domain.Entities;
using System;

namespace Lms.Application.Features.EventType.Queries.GetEventTypePagedList
{
    public class GetEventTypePagedListQueryResponse : AAuditableEntity<Guid> //Tabloda görünmesini istediğimiz bilgiler
    {
        public string Name { get; set; }
    }
}
