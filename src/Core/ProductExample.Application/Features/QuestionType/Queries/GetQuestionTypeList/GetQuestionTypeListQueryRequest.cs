using Lms.Application.Features.Notification.Queries.GetNotificationList;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.QuestionType.Queries.GetQuestionTypeList
{
    public class GetQuestionTypeListQueryRequest : IRequest<IDataResult<IEnumerable<GetQuestionTypeListQueryResponse>>>
    {
    }
}
