using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Curriculum.Queries.GetCurriculumList
{
    public class GetCurriculumListQueryHandler : IRequestHandler<GetCurriculumListQueryRequest, IDataResult<IEnumerable<GetCurriculumListQueryResponse>>>
    {
        readonly ICurriculumRepository _curriculumRepository;
        IMapper _mapper;
        public GetCurriculumListQueryHandler(ICurriculumRepository curriculumRepository, IMapper mapper)
        {
            _curriculumRepository = curriculumRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<IEnumerable<GetCurriculumListQueryResponse>>> Handle(GetCurriculumListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _curriculumRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetCurriculumListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetCurriculumListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
