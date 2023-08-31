using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Lessons.Queries.GetLessonsById
{
    public class GetLessonsByIdQueryHandler : IRequestHandler<GetLessonsByIdQueryRequest, IDataResult<GetLessonsByIdQueryResponse>>
    {
        readonly ILessonsRepository _lessonsRepository;
        IMapper _mapper;

        public GetLessonsByIdQueryHandler(ILessonsRepository lessonsRepository, IMapper mapper)
        {
            _lessonsRepository = lessonsRepository;
            _mapper = mapper;
        }


        public async Task<IDataResult<GetLessonsByIdQueryResponse>> Handle(GetLessonsByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _lessonsRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetLessonsByIdQueryResponse>(data);
            return new DataResult<GetLessonsByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
