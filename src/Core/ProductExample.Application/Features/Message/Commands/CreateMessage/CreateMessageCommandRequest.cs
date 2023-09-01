using Lms.Application.Features.Base;
using Lms.Domain.Entities;
using System;

namespace Lms.Application.Features.Message.Commands.CreateMessage
{
    public class CreateMessageCommandRequest:BaseRequest
    {
        public int? SenderId { get; set; }
        public Lms.Domain.Entities.User Sender { get; set; }
        public int? ReceiverId { get; set; }
        public Lms.Domain.Entities.User Receiver { get; set; }
        public int ChatId { get; set; }
        public Lms.Domain.Entities.Chat Chat { get; set; }
        public string Text { get; set; }
        public DateTime SendDate { get; set; }
    }
}
