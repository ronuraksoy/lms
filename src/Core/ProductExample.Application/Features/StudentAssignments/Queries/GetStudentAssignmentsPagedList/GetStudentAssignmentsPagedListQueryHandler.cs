using AutoMapper;
using Lms.Application.Features.Teacher.Queries.GetTeacherPagedList;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.StudentAssignments.Queries.GetStudentAssignmentsPagedList
{
    public class GetStudentAssignmentsPagedListQueryHandler : IRequestHandler<GetStudentAssignmentsPagedListQueryRequest, IPagedDataResult<GetStudentAssignmentsPagedListQueryResponse>>
    {
        readonly IStudentAssignmentsRepository _studentAssignmentsRepository;
        IMapper _mapper;
        public async Task<IPagedDataResult<GetStudentAssignmentsPagedListQueryResponse>> Handle(GetStudentAssignmentsPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _studentAssignmentsRepository.GetPagedList(request);
            var result = _mapper.Map<IEnumerable<GetStudentAssignmentsPagedListQueryResponse>>(data.Data);
            return new PagedDataResult<GetStudentAssignmentsPagedListQueryResponse>(data.RecordsTotal, data.RecordsFiltered, result, true, "Başarılı işlem...");
        }

        public GetStudentAssignmentsPagedListQueryHandler(IStudentAssignmentsRepository studentAssignmentsRepository, IMapper mapper)
        {
            _studentAssignmentsRepository = studentAssignmentsRepository;
            _mapper = mapper;
        }
    }
}
