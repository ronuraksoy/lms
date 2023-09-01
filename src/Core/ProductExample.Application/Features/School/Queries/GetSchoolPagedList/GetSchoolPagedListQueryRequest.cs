using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.School.Queries.GetSchoolPagedList
{
    public class GetSchoolPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetSchoolPagedListQueryResponse>>
    {
        public string? NameFilter { get; set; }
    }
}
