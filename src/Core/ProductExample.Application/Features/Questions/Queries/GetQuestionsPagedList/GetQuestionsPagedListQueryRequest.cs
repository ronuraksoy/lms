using Lms.Application.Features.Notification.Queries.GetNotificationPagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.Questions.Queries.GetQuestionPagedList
{
    public class GetQuestionsPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetQuestionsPagedListQueryResponse>>
    {
    }
}
