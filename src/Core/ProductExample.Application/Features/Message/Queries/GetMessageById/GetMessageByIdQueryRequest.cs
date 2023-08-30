using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.Message.Queries.GetMessageById
{
    public class GetMessageByIdQueryRequest:IRequest<IDataResult<GetMessageByIdQueryResponse>>
    {
        public Guid Id { get; set; }
        public GetMessageByIdQueryRequest(Guid Id)
        {
            this.Id = Id;
        }
    }
}
