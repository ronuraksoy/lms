using Lms.Application.Features.Notification.Queries.GetNotificationById;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.QuestionType.Queries.GetQuestionTypeById
{
    public class GetQuestionTypeByIdQueryRequest : IRequest<IDataResult<GetQuestionTypeByIdQueryResponse>>
    {
        public Guid Id { get; set; }
        public GetQuestionTypeByIdQueryRequest(Guid Id)
        {
            this.Id = Id;
        }
    }
}
