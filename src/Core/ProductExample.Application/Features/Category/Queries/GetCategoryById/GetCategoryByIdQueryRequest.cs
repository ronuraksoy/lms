using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.Category.Queries.GetCategoryById
{
    public class GetCategoryByIdQueryRequest : IRequest<IDataResult<GetCategoryByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetCategoryByIdQueryRequest(Guid Id) 
        {
            this.Id = Id;
        }
    }
}
