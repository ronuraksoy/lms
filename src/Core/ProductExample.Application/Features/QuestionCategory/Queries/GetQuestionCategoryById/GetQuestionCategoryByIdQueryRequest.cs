using Lms.Application.Features.Notification.Queries.GetNotificationById;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.QuestionCategory.Queries.GetQuestionCategoryById
{
    public class GetQuestionCategoryByIdQueryRequest: IRequest<IDataResult<GetQuestionCategoryByIdQueryResponse>>
    {
        public Guid Id { get; set; }
        public GetQuestionCategoryByIdQueryRequest(Guid Id)
        {
            this.Id = Id;
        }
    }
}
