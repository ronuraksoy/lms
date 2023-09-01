using System;

namespace Lms.Application.Features.Events.Queries.GetEventsById
{
    public class GetEventsByIdQueryResponse
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
        public Lms.Domain.Entities.EventType EventType { get; set; }
        public bool showUserCount { get; set; }
        public bool isDeleted { get; set; }
        public bool isActive { get; set; }
        public string Location { get; set; }
        public string MeetingPath { get; set; }
    }
}
