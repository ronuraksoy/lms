using Lms.Application.Features.Teacher.Queries.GetAchievementCategoryById;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.Payment.Queries.GetPaymentById
{
    public class GetPaymentByIdQueryRequest : IRequest<IDataResult<GetPaymentByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetPaymentByIdQueryRequest(Guid Id)
        {
            this.Id = Id;
        }
    }
}
