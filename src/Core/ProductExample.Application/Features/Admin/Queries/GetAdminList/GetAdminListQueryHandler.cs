using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Admin.Queries.GetAdminList
{
    public class GetAdminListQueryHandler : IRequestHandler<GetAdminListQueryRequest, IDataResult<IEnumerable<GetAdminListQueryResponse>>>
    {
        readonly IAdminRepository _adminRepository;
        IMapper _mapper;
        public GetAdminListQueryHandler(IAdminRepository adminRepository, IMapper mapper)
        {
            _adminRepository = adminRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<IEnumerable<GetAdminListQueryResponse>>> Handle(GetAdminListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _adminRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetAdminListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetAdminListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
