using Lms.Comman.Domain.Entities;
using MediatR;
using System;

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
