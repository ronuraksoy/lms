﻿using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class Message : AAuditableEntity<Guid>
    {
        public int? SenderId { get; set; }
        public virtual User Sender { get; set; }
        public int? ReceiverId { get; set; }
        public virtual User Receiver { get; set; }
        public int ChatId { get; set; }
        public virtual Chat Chat { get; set; }
        public string Text { get; set; }
        public DateTime SendDate { get; set; }
    }
}
