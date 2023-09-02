using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.Chat.Queries.GetChatById
{
    public class GetChatByIdQueryRequest : IRequest<IDataResult<GetChatByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetChatByIdQueryRequest(Guid Id) 
        {
            this.Id = Id;
        }
    }
}
