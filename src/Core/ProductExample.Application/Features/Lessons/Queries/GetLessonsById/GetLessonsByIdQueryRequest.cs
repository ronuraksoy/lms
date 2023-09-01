using Lms.Comman.Domain.Entities;
using MediatR;
using System;

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
