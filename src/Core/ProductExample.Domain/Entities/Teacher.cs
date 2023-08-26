﻿using Lms.Common.Domain.Entities;
using Lms.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class Teacher : AAuditableEntity<Guid>
    {
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
        public string? Detail { get; set; }
        public string? Note { get; set; }
    }
}
