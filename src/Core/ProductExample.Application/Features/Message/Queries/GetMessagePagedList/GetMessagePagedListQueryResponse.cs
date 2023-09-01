using Lms.Comman.Domain.Entities;
using Lms.Domain.Entities;
using System;

namespace Lms.Application.Features.Message.Queries.GetMessagePagedList
{
    public class GetMessagePagedListQueryResponse:AAuditableEntity<Guid>
    {
        public int? SenderId { get; set; }
        public User Sender { get; set; }
        public int? ReceiverId { get; set; }
        public User Receiver { get; set; }
        public int ChatId { get; set; }
        public Chat Chat { get; set; }
        public string Text { get; set; }
        public DateTime SendDate { get; set; }
    }
}
