using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.StudentExamEntitlement.Queries.GetStudentExamEntitlementById
{
    public class GetStudentExamEntitlementByIdQueryRequest : IRequest<IDataResult<GetStudentExamEntitlementByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetStudentExamEntitlementByIdQueryRequest(Guid Id) 
        {
            this.Id = Id;
        }
    }
}
