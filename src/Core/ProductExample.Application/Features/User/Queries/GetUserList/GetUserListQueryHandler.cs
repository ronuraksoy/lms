using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.User.Queries.GetUserList
{
    public class GetUserListQueryHandler : IRequestHandler<GetUserListQueryRequest, IDataResult<IEnumerable<GetUserListQueryResponse>>>
    {
        readonly IUserRepository _userRepository;
        IMapper _mapper;
        public GetUserListQueryHandler(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<IEnumerable<GetUserListQueryResponse>>> Handle(GetUserListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _userRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetUserListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetUserListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
