using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.CurriculumLesson.Queries.GetCurriculumLessonById
{
    public class GetCurriculumLessonByIdQueryRequest : IRequest<IDataResult<GetCurriculumLessonByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetCurriculumLessonByIdQueryRequest(Guid Id) 
        {
            this.Id = Id;
        }
    }
}
