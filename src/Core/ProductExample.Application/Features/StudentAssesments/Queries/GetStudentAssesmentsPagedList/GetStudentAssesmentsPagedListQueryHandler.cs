using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.StudentAssesments.Queries.GetStudentAssesmentsPagedList
{
    public class GetStudentAssesmentsPagedListQueryHandler : IRequestHandler<GetStudentAssesmentsPagedListQueryRequest, IPagedDataResult<GetStudentAssesmentsPagedListQueryResponse>>
    {
        readonly IStudentAssesmentsRepository _studentAssesmentsRepository;
        IMapper _mapper;
        public Task<IPagedDataResult<GetStudentAssesmentsPagedListQueryResponse>> Handle(GetStudentAssesmentsPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public GetStudentAssesmentsPagedListQueryHandler(IStudentAssesmentsRepository studentAssesmentsRepository, IMapper mapper)
        {
            _studentAssesmentsRepository = studentAssesmentsRepository;
            _mapper = mapper;
        }
    }
}
