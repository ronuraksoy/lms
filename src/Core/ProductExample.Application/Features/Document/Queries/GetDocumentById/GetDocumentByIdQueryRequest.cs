using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.Document.Queries.GetDocumentById
{
    public class GetDocumentByIdQueryRequest : IRequest<IDataResult<GetDocumentByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetDocumentByIdQueryRequest(Guid Id) 
        {
            this.Id = Id;
        }
    }
}
