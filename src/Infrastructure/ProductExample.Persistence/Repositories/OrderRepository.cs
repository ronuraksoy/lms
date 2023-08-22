using Lms.Application.Interfaces.Repositories;
using Lms.Domain.Entities;
using Lms.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Persistence.Repositories
{
    public class OrderRepository : Repository<User>, IOrderRepository
    {
        public OrderRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
