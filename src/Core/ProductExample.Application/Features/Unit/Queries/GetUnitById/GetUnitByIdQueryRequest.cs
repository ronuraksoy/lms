using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.Unit.Queries.GetUnitById
{
    public class GetUnitByIdQueryRequest : IRequest<IDataResult<GetUnitByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetUnitByIdQueryRequest(Guid Id) 
        {
            this.Id = Id;
        }
    }
}
