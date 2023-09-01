using AutoMapper;
using Lms.Application.Features.Teacher.Queries.GetTeacherPagedList;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.StudentExamLogs.Queries.GetStudentExamLogsPagedList
{
    public class GetStudentExamLogsPagedListQueryHandler : IRequestHandler<GetStudentExamLogsPagedListQueryRequest, IPagedDataResult<GetStudentExamLogsPagedListQueryResponse>>
    {
        readonly IStudentExamLogsRepository _studentExamLogsRepository;
        IMapper _mapper;
        public async Task<IPagedDataResult<GetStudentExamLogsPagedListQueryResponse>> Handle(GetStudentExamLogsPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _studentExamLogsRepository.GetPagedList(request);
            var result = _mapper.Map<IEnumerable<GetStudentExamLogsPagedListQueryResponse>>(data.Data);
            return new PagedDataResult<GetStudentExamLogsPagedListQueryResponse>(data.RecordsTotal, data.RecordsFiltered, result, true, "Başarılı işlem...");
        }

        public GetStudentExamLogsPagedListQueryHandler(IStudentExamLogsRepository studentExamLogsRepository, IMapper mapper)
        {
            _studentExamLogsRepository = studentExamLogsRepository;
            _mapper = mapper;
        }
    }
}
