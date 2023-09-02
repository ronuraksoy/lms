using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.Document.Queries.GetDocumentList
{
    public class GetDocumentListQueryRequest : IRequest<IDataResult<IEnumerable<GetDocumentListQueryResponse>>>
    {
    }
}
