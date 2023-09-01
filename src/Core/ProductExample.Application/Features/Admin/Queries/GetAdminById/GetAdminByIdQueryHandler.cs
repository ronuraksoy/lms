using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Admin.Queries.GetAdminById
{
    public class GetAdminByIdQueryHandler : IRequestHandler<GetAdminByIdQueryRequest, IDataResult<GetAdminByIdQueryResponse>>
    {
        readonly IAdminRepository _adminRepository;
        IMapper _mapper;
        public GetAdminByIdQueryHandler(IAdminRepository adminRepository, IMapper mapper)
        {
            _adminRepository = adminRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<GetAdminByIdQueryResponse>> Handle(GetAdminByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _adminRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetAdminByIdQueryResponse>(data);
            return new DataResult<GetAdminByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
