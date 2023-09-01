using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.School.Queries.GetSchoolList
{
    public class GetSchoolListQueryHandler : IRequestHandler<GetSchoolListQueryRequest, IDataResult<IEnumerable<GetSchoolListQueryResponse>>>
    {
        readonly ISchoolRepository _schoolRepository;
        IMapper _mapper;
        public GetSchoolListQueryHandler(ISchoolRepository schoolRepository, IMapper mapper)
        {
            _schoolRepository = schoolRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<IEnumerable<GetSchoolListQueryResponse>>> Handle(GetSchoolListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _schoolRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetSchoolListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetSchoolListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
