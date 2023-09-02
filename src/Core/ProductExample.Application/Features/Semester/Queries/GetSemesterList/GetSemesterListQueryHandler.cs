using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Semester.Queries.GetSemesterList
{
    public class GetSemesterListQueryHandler : IRequestHandler<GetSemesterListQueryRequest, IDataResult<IEnumerable<GetSemesterListQueryResponse>>>
    {
        readonly ISemesterRepository _semesterRepository;
        IMapper _mapper;
        public GetSemesterListQueryHandler(ISemesterRepository semesterRepository, IMapper mapper)
        {
            _semesterRepository = semesterRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<IEnumerable<GetSemesterListQueryResponse>>> Handle(GetSemesterListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _semesterRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetSemesterListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetSemesterListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
