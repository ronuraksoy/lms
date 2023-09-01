using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.Exams.Queries.GetExamsById
{
    public class GetExamsByIdQueryRequest : IRequest<IDataResult<GetExamsByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetExamsByIdQueryRequest(Guid Id) 
        {
            this.Id = Id;
        }
    }
}
