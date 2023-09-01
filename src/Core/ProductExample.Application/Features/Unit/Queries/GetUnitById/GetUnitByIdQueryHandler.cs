using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Unit.Queries.GetUnitById
{
    public class GetUnitByIdQueryHandler : IRequestHandler<GetUnitByIdQueryRequest, IDataResult<GetUnitByIdQueryResponse>>
    {
        readonly IUnitRepository _unitRepository;
        IMapper _mapper;
        public GetUnitByIdQueryHandler(IUnitRepository unitRepository, IMapper mapper)
        {
            _unitRepository = unitRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<GetUnitByIdQueryResponse>> Handle(GetUnitByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _unitRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetUnitByIdQueryResponse>(data);
            return new DataResult<GetUnitByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
