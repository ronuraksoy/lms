using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.StudentAssesments.Queries.GetStudentAssesmentsById
{
    public class GetStudentAssesmentsByIdQueryRequest : IRequest<IDataResult<GetStudentAssesmentsByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetStudentAssesmentsByIdQueryRequest(Guid Id) 
        {
            this.Id = Id;
        }
    }
}
