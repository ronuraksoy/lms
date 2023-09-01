using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.EventParticipants.Queries.GetEventParticipantsById
{
    public class GetEventParticipantsByIdQueryResponse
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
