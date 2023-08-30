using Lms.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.Message.Queries.GetMessageById
{
    public class GetMessageByIdQueryResponse
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
