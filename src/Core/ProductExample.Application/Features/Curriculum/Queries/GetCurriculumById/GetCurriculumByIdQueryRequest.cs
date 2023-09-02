using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.Curriculum.Queries.GetCurriculumById
{
    public class GetCurriculumByIdQueryRequest : IRequest<IDataResult<GetCurriculumByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetCurriculumByIdQueryRequest(Guid Id) 
        {
            this.Id = Id;
        }
    }
}
