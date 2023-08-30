using Lms.Comman.Domain.Entities;
using Lms.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.Notification.Queries.GetNotificationPagedList
{
    public class GetNotificationPagedListQueryResponse:AAuditableEntity<Guid>
    {
        public string Content { get; set; }
        public char SendUserType { get; set; }
        public int SendUserID { get; set; }
        public User SenderUser { get; set; }
        public int ComeUserID { get; set; }
        public User ComeUser { get; set; }
        public DateTime NotificationTime { get; set; }
        public bool IsRead { get; set; }
    }
}
