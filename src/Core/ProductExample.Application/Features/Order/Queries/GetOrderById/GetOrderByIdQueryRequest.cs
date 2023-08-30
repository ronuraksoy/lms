using Lms.Application.Features.Teacher.Queries.GetCategoryById;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.Order.Queries.GetOrderById
{
    public class GetOrderByIdQueryRequest : IRequest<IDataResult<GetOrderByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetOrderByIdQueryRequest(Guid Id)
        {
            this.Id = Id;
        }
    }
}
