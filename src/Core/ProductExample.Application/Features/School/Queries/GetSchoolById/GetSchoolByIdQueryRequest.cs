using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.School.Queries.GetSchoolById
{
    public class GetSchoolByIdQueryRequest : IRequest<IDataResult<GetSchoolByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetSchoolByIdQueryRequest(Guid Id) 
        {
            this.Id = Id;
        }
    }
}
