using Lms.Application.Features.Base;
using Lms.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.Events.Commands.CreateEvents
{
    public class CreateEventsCommandRequest : BaseRequest
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
