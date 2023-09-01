using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.Educations.Queries.GetEducationsById
{
    public class GetEducationsByIdQueryRequest : IRequest<IDataResult<GetEducationsByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetEducationsByIdQueryRequest(Guid Id) 
        {
            this.Id = Id;
        }
    }
}
