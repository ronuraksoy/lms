using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.Achievements.Queries.GetAchievementsPagedList
{
    public class GetAchievementsPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetAchievementsPagedListQueryResponse>>
    {
    }
}
