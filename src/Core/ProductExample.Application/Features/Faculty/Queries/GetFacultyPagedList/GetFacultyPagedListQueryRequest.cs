using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.Faculty.Queries.GetFacultyPagedList
{
    public class GetFacultyPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetFacultyPagedListQueryResponse>>
    {
    }
}
