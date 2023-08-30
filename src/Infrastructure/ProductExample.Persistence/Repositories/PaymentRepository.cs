using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Persistence.Repositories;
using Lms.Domain.Entities;
using Lms.Persistence.Context;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Persistence.Repositories
{
    public class PaymentRepository : AAuditableRepository<Payment, ApplicationDbContext>, IPaymentRepository
    {
        public PaymentRepository(ApplicationDbContext dbContext, ILogger<Payment> logger) : base(dbContext, logger)
        {
        }
    }
}
