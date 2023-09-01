using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.Teacher.Queries.GetTeacherPagedList
{
    public class GetTeacherPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetTeacherPagedListQueryResponse>>
    {
        public string? NameFilter { get; set; }
    }
}
