using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Curriculum.Queries.GetCurriculumPagedList
{
    public class GetCurriculumPagedListQueryHandler : IRequestHandler<GetCurriculumPagedListQueryRequest, IPagedDataResult<GetCurriculumPagedListQueryResponse>>
    {
        readonly ICurriculumRepository _curriculumRepository;
        IMapper _mapper;
        public GetCurriculumPagedListQueryHandler(ICurriculumRepository curriculumRepository, IMapper mapper)
        {
            _curriculumRepository = curriculumRepository;
            _mapper = mapper;
        }
        public async Task<IPagedDataResult<GetCurriculumPagedListQueryResponse>> Handle(GetCurriculumPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _curriculumRepository.GetPagedList(request);
            var result = _mapper.Map<IEnumerable<GetCurriculumPagedListQueryResponse>>(data.Data);
            return new PagedDataResult<GetCurriculumPagedListQueryResponse>(data.RecordsTotal, data.RecordsFiltered, result, true, "Başarılı işlem...");
        }
    }
}
