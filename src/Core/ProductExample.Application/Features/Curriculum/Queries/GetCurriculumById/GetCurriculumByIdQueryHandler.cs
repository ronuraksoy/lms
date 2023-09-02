using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Curriculum.Queries.GetCurriculumById
{
    public class GetCurriculumByIdQueryHandler : IRequestHandler<GetCurriculumByIdQueryRequest, IDataResult<GetCurriculumByIdQueryResponse>>
    {
        readonly ICurriculumRepository _curriculumRepository;
        IMapper _mapper;
        public GetCurriculumByIdQueryHandler(ICurriculumRepository curriculumRepository, IMapper mapper)
        {
            _curriculumRepository = curriculumRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<GetCurriculumByIdQueryResponse>> Handle(GetCurriculumByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _curriculumRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetCurriculumByIdQueryResponse>(data);
            return new DataResult<GetCurriculumByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
