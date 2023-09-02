using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.ContactMessage.Queries.GetContactMessageById
{
    public class GetContactMessageByIdQueryRequest : IRequest<IDataResult<GetContactMessageByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetContactMessageByIdQueryRequest(Guid Id) 
        {
            this.Id = Id;
        }
    }
}
