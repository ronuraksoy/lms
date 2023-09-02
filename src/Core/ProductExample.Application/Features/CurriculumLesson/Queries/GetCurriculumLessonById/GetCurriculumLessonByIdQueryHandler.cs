using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.CurriculumLesson.Queries.GetCurriculumLessonById
{
    public class GetCurriculumLessonByIdQueryHandler : IRequestHandler<GetCurriculumLessonByIdQueryRequest, IDataResult<GetCurriculumLessonByIdQueryResponse>>
    {
        readonly ICurriculumLessonRepository _curriculumLessonRepository;
        IMapper _mapper;
        public GetCurriculumLessonByIdQueryHandler(ICurriculumLessonRepository curriculumLessonRepository, IMapper mapper)
        {
            _curriculumLessonRepository = curriculumLessonRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<GetCurriculumLessonByIdQueryResponse>> Handle(GetCurriculumLessonByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _curriculumLessonRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetCurriculumLessonByIdQueryResponse>(data);
            return new DataResult<GetCurriculumLessonByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
