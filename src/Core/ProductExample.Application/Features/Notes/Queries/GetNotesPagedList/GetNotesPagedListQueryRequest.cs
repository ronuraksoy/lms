using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.Notes.Queries.GetNotesPagedList
{
    public class GetNotesPagedListQueryRequest:DtParameters,IRequest<IPagedDataResult<GetNotesPagedListQueryResponse>>
    {
    }
}
