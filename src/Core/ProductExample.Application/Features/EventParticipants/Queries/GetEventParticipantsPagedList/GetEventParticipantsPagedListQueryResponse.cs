using Lms.Comman.Domain.Entities;
using System;

namespace Lms.Application.Features.EventParticipants.Queries.GetEventParticipantsPagedList
{
    public class GetEventParticipantsPagedListQueryResponse : AAuditableEntity<Guid> //Tabloda görünmesini istediğimiz bilgiler
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public int? UserID { get; set; }
        public Lms.Domain.Entities.User User { get; set; }
        public int EventID { get; set; }
        public Lms.Domain.Entities.Events Events { get; set; }
    }
}
