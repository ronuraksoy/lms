using AutoMapper;
using Lms.Application.Features.Teacher.Queries.GetTeacherPagedList;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.StudentAnswers.Queries.GetStudentAnswersPagedList
{
    public class GetStudentAnswersPagedListQueryHandler : IRequestHandler<GetStudentAnswersPagedListQueryRequest, IPagedDataResult<GetStudentAnswersPagedListQueryResponse>>
    {
        readonly IStudentAnswersRepository _studentAnswersRepository;
        IMapper _mapper;
        public async Task<IPagedDataResult<GetStudentAnswersPagedListQueryResponse>> Handle(GetStudentAnswersPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _studentAnswersRepository.GetPagedList(request);
            var result = _mapper.Map<IEnumerable<GetStudentAnswersPagedListQueryResponse>>(data.Data);
            return new PagedDataResult<GetStudentAnswersPagedListQueryResponse>(data.RecordsTotal, data.RecordsFiltered, result, true, "Başarılı işlem...");
        }

        public GetStudentAnswersPagedListQueryHandler(IStudentAnswersRepository studentAnswersRepository, IMapper mapper)
        {
            _studentAnswersRepository = studentAnswersRepository;
            _mapper = mapper;
        }
    }
}
