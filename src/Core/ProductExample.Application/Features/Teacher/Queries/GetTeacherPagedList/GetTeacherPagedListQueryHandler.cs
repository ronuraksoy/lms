using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Teacher.Queries.GetTeacherPagedList
{
    public class GetTeacherPagedListQueryHandler : IRequestHandler<GetTeacherPagedListQueryRequest, IPagedDataResult<GetTeacherPagedListQueryResponse>>
    {
        readonly ITeacherRepository _teacherRepository;
        IMapper _mapper;
        public GetTeacherPagedListQueryHandler(ITeacherRepository teacherRepository, IMapper mapper)
        {
            _teacherRepository = teacherRepository;
            _mapper = mapper;
        }
        public async Task<IPagedDataResult<GetTeacherPagedListQueryResponse>> Handle(GetTeacherPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _teacherRepository.GetPagedList(request);
            var result = _mapper.Map<IEnumerable<GetTeacherPagedListQueryResponse>>(data.Data);
            return new PagedDataResult<GetTeacherPagedListQueryResponse>(data.RecordsTotal, data.RecordsFiltered, result, true, "Başarılı işlem...");
        }
    }
}
