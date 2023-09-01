using AutoMapper;
using Lms.Application.Features.Teacher.Queries.GetTeacherPagedList;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Student.Queries.GetStudentPagedList
{
    public class GetStudentPagedListQueryHandler : IRequestHandler<GetStudentPagedListQueryRequest, IPagedDataResult<GetStudentPagedListQueryResponse>>
    {
        readonly IStudentRepository _studentRepository;
        IMapper _mapper;
        public async Task<IPagedDataResult<GetStudentPagedListQueryResponse>> Handle(GetStudentPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _studentRepository.GetPagedList(request);
            var result = _mapper.Map<IEnumerable<GetStudentPagedListQueryResponse>>(data.Data);
            return new PagedDataResult<GetStudentPagedListQueryResponse>(data.RecordsTotal, data.RecordsFiltered, result, true, "Başarılı işlem...");
        }

        public GetStudentPagedListQueryHandler(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }
    }
}
