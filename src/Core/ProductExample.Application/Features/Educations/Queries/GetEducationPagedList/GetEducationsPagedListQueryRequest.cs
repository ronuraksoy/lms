using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.Educations.Queries.GetEducationsPagedList
{
    public class GetEducationsPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetEducationsPagedListQueryResponse>>
    {
        public string? NameFilter { get; set; }
    }
}
