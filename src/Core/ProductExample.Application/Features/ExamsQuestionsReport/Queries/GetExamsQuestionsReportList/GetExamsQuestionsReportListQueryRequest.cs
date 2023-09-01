using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.ExamsQuestionsReport.Queries.GetExamsQuestionsReportList
{
    public class GetExamsQuestionsListQueryRequest : IRequest<IDataResult<IEnumerable<GetExamsQuestionsListQueryResponse>>>
    {
    }
}
