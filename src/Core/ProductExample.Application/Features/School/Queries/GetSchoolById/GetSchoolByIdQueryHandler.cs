using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.School.Queries.GetSchoolById
{
    public class GetSchoolByIdQueryHandler : IRequestHandler<GetSchoolByIdQueryRequest, IDataResult<GetSchoolByIdQueryResponse>>
    {
        readonly ISchoolRepository _schoolRepository;
        IMapper _mapper;
        public GetSchoolByIdQueryHandler(ISchoolRepository schoolRepository, IMapper mapper)
        {
            _schoolRepository = schoolRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<GetSchoolByIdQueryResponse>> Handle(GetSchoolByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _schoolRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetSchoolByIdQueryResponse>(data);
            return new DataResult<GetSchoolByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
