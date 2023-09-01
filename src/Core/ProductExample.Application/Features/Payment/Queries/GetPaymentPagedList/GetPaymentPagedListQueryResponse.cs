using Lms.Comman.Domain.Entities;
using System;

namespace Lms.Application.Features.Payment.Queries.GetPaymentPagedList
{
    public class GetPaymentPagedListQueryResponse : AAuditableEntity<Guid>
    {
        public string EducationPay { get; set; }
        public string Note { get; set; }
    }
}
