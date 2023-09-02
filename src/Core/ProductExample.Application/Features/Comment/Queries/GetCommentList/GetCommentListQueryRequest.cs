using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.Comment.Queries.GetCommentList
{
    public class GetCommentListQueryRequest : IRequest<IDataResult<IEnumerable<GetCommentListQueryResponse>>>
    {
    }
}
