using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.Student.Queries.GetStudentPagedList
{
    public class GetStudentPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetStudentPagedListQueryResponse>>
    {
    }
}
