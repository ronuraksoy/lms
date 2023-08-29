using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.Category.Queries.GetCategoryPagedList
{
    public class GetCategoryPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetCategoryPagedListQueryResponse>>
    {
    }
}
