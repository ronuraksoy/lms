using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.Notes.Queries.GetNotesById
{
    public class GetNotesByIdQueryRequest:IRequest<IDataResult<GetNotesByIdQueryResponse>>
    {
        public Guid Id { get; set; }
        public GetNotesByIdQueryRequest(Guid Id)
        {
            this.Id = Id;
        }
    }
}
