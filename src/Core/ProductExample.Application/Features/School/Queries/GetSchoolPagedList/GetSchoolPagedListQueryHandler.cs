using AutoMapper;
using Lms.Application.Features.Teacher.Queries.GetTeacherPagedList;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.School.Queries.GetSchoolPagedList
{
    public class GetSchoolPagedListQueryHandler : IRequestHandler<GetSchoolPagedListQueryRequest, IPagedDataResult<GetSchoolPagedListQueryResponse>>
    {
        readonly ISchoolRepository _schoolRepository;
        IMapper _mapper;
        public GetSchoolPagedListQueryHandler(ISchoolRepository schoolRepository, IMapper mapper)
        {
            _schoolRepository = schoolRepository;
            _mapper = mapper;
        }
        public async Task<IPagedDataResult<GetSchoolPagedListQueryResponse>> Handle(GetSchoolPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _schoolRepository.GetPagedList(request);
            var result = _mapper.Map<IEnumerable<GetSchoolPagedListQueryResponse>>(data.Data);
            return new PagedDataResult<GetSchoolPagedListQueryResponse>(data.RecordsTotal, data.RecordsFiltered, result, true, "Başarılı işlem...");
        }
    }
}
