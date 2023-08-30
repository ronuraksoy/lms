using Lms.Application.Features.Notification.Queries.GetNotificationList;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.QuestionCategory.Queries.GetQuestionCategoryList
{
    public class GetQuestionCategoryListQueryRequest : IRequest<IDataResult<IEnumerable<GetQuestionCategoryListQueryResponse>>>
    {
    }
}
