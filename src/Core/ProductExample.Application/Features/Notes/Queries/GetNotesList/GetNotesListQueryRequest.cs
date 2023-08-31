using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.Notes.Queries.GetNotesList
{
    public class GetNotesListQueryRequest : IRequest<IDataResult<IEnumerable<GetNotesListQueryResponse>>>
    {
    }
}
