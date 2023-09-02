using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.CurriculumLesson.Queries.GetCurriculumLessonPagedList
{
    public class GetCurriculumLessonPagedListQueryHandler : IRequestHandler<GetCurriculumLessonPagedListQueryRequest, IPagedDataResult<GetCurriculumLessonPagedListQueryResponse>>
    {
        readonly ICurriculumLessonRepository _curriculumLessonRepository;
        IMapper _mapper;
        public GetCurriculumLessonPagedListQueryHandler(ICurriculumLessonRepository curriculumLessonRepository, IMapper mapper)
        {
            _curriculumLessonRepository = curriculumLessonRepository;
            _mapper = mapper;
        }
        public async Task<IPagedDataResult<GetCurriculumLessonPagedListQueryResponse>> Handle(GetCurriculumLessonPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _curriculumLessonRepository.GetPagedList(request);
            var result = _mapper.Map<IEnumerable<GetCurriculumLessonPagedListQueryResponse>>(data.Data);
            return new PagedDataResult<GetCurriculumLessonPagedListQueryResponse>(data.RecordsTotal, data.RecordsFiltered, result, true, "Başarılı işlem...");
        }
    }
}
