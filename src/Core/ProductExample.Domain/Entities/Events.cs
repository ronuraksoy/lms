using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
   public class Events : AAuditableEntity<Guid>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime Hour { get; set; }
        public int Time { get; set; }
        public string Photo { get; set; }
        public string Video { get; set; }
        public int UserCount { get; set; }
        public int EventTypeID { get; set; }
        public virtual EventType EventType { get; set; }
        public bool showUserCount { get; set; }
        public bool isDeleted { get; set; }
        public bool isActive { get; set; }
        public string Location { get; set; }
        public string MeetingPath { get; set; }
        public virtual IEnumerable<EventParticipants> EventParticipants { get; set; }
        public virtual IEnumerable<EventParticipantsAnswer> EventParticipantsAnswers { get; set; }
        public virtual IEnumerable<EventQuestions> EventQuestions { get; set; }
        public virtual IEnumerable<EventSpeakers> EventSpeakers { get; set; }
    }
}
