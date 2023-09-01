using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.Classrooms.Queries.GetClassroomsPagedList
{
    public class GetClassroomsPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetClassroomsPagedListQueryResponse>>
    {
        public string? NameFilter { get; set; }
    }
}
