using Lms.Common.Application.Repositories;
using Lms.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Repositories
{
    public interface INotificationRepository : IRepository<Notification>
    {
    }
}
