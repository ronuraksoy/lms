using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.Lessons.Queries.GetLessonsById
{
    public class GetLessonsByIdQueryRequest:IRequest<IDataResult<GetLessonsByIdQueryResponse>>
    {
        public Guid Id { get; set; }
        public GetLessonsByIdQueryRequest(Guid Id)
        {
            this.Id = Id;
        }
    }
}
