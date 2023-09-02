using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Semester.Queries.GetSemesterById
{
    public class GetSemesterByIdQueryHandler : IRequestHandler<GetSemesterByIdQueryRequest, IDataResult<GetSemesterByIdQueryResponse>>
    {
        readonly ISemesterRepository _semesterRepository;
        IMapper _mapper;
        public GetSemesterByIdQueryHandler(ISemesterRepository semesterRepository, IMapper mapper)
        {
            _semesterRepository = semesterRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<GetSemesterByIdQueryResponse>> Handle(GetSemesterByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _semesterRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetSemesterByIdQueryResponse>(data);
            return new DataResult<GetSemesterByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
