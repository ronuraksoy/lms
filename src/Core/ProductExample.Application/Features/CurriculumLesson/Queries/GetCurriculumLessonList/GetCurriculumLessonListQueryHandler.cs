using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.CurriculumLesson.Queries.GetCurriculumLessonList
{
    public class GetCurriculumLessonListQueryHandler : IRequestHandler<GetCurriculumLessonListQueryRequest, IDataResult<IEnumerable<GetCurriculumLessonListQueryResponse>>>
    {
        readonly ICurriculumLessonRepository _curriculumLessonRepository;
        IMapper _mapper;
        public GetCurriculumLessonListQueryHandler(ICurriculumLessonRepository curriculumLessonRepository, IMapper mapper)
        {
            _curriculumLessonRepository = curriculumLessonRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<IEnumerable<GetCurriculumLessonListQueryResponse>>> Handle(GetCurriculumLessonListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _curriculumLessonRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetCurriculumLessonListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetCurriculumLessonListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
