using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.Lessons.Queries.GetLessonsPagedList
{
    public class GetLessonsPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetLessonsPagedListQueryResponse>>
    {
    }
}
