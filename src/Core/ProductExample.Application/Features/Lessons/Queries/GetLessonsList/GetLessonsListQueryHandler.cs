using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Lessons.Queries.GetLessonsList
{
    public class GetLessonsListQueryHandler : IRequestHandler<GetLessonsListQueryRequest, IDataResult<IEnumerable<GetLessonsListQueryResponse>>>
    {
        readonly ILessonsRepository _lessonsRepository;
        IMapper _mapper;

        public GetLessonsListQueryHandler(IMapper mapper, ILessonsRepository lessonsRepository)
        {
            _mapper = mapper;
            _lessonsRepository = lessonsRepository;
        }


        public async Task<IDataResult<IEnumerable<GetLessonsListQueryResponse>>> Handle(GetLessonsListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _lessonsRepository.GetListAsync();
            var result =_mapper.Map<IEnumerable<GetLessonsListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetLessonsListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
