using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Unit.Queries.GetUnitList
{
    public class GetUnitListQueryHandler : IRequestHandler<GetUnitListQueryRequest, IDataResult<IEnumerable<GetUnitListQueryResponse>>>
    {
        readonly IUnitRepository _unitRepository;
        IMapper _mapper;
        public GetUnitListQueryHandler(IUnitRepository unitRepository, IMapper mapper)
        {
            _unitRepository = unitRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<IEnumerable<GetUnitListQueryResponse>>> Handle(GetUnitListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _unitRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetUnitListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetUnitListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
