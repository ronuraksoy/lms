using Lms.Application.Features.Notification.Queries.GetNotificationById;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.Questions.Queries.GetQuestionById
{
    public class GetQuestionsByIdQueryRequest : IRequest<IDataResult<GetQuestionsByIdQueryResponse>>
    {
        public Guid Id { get; set; }
        public GetQuestionsByIdQueryRequest(Guid Id)
        {
            this.Id = Id;
        }
    }
}
