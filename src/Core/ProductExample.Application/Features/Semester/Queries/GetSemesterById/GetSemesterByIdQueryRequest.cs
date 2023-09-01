using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.Semester.Queries.GetSemesterById
{
    public class GetSemesterByIdQueryRequest : IRequest<IDataResult<GetSemesterByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetSemesterByIdQueryRequest(Guid Id) 
        {
            this.Id = Id;
        }
    }
}
