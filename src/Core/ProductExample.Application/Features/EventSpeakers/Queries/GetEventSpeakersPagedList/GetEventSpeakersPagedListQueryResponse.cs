using Lms.Comman.Domain.Entities;
using System;

namespace Lms.Application.Features.EventSpeakers.Queries.GetEventSpeakersPagedList
{
    public class GetEventSpeakersPagedListQueryResponse : AAuditableEntity<Guid> //Tabloda görünmesini istediğimiz bilgiler
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Title { get; set; }
        public string LinkedIn { get; set; }
        public string Photo { get; set; }
        public string EventID { get; set; }
        public Lms.Domain.Entities.Events Events { get; set; }
    }
}
