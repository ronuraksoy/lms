using Microsoft.EntityFrameworkCore;
using Lms.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Context
{
    public interface IApplicationDbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Orders { get; set; }
    }
}
