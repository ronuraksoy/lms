using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Educations.Queries.GetEducationsById
{
    public class GetEducationsByIdQueryHandler : IRequestHandler<GetEducationsByIdQueryRequest, IDataResult<GetEducationsByIdQueryResponse>>
    {
        readonly IEducationsRepository _educationsRepository;
        IMapper _mapper;
        public GetEducationsByIdQueryHandler(IEducationsRepository educationsRepository, IMapper mapper)
        {
            _educationsRepository = educationsRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<GetEducationsByIdQueryResponse>> Handle(GetEducationsByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _educationsRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetEducationsByIdQueryResponse>(data);
            return new DataResult<GetEducationsByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
