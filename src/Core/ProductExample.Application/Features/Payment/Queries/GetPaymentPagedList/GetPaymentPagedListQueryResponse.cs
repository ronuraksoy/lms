using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.Payment.Queries.GetPaymentPagedList
{
    public class GetPaymentPagedListQueryResponse : AAuditableEntity<Guid>
    {
        public string EducationPay { get; set; }
        public string Note { get; set; }
    }
}
