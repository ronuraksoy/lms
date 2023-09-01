using AutoMapper;
using Lms.Application.Features.Teacher.Queries.GetTeacherPagedList;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.User.Queries.GetUserPagedList
{
    public class GetUserPagedListQueryHandler : IRequestHandler<GetUserPagedListQueryRequest, IPagedDataResult<GetUserPagedListQueryResponse>>
    {
        readonly IUserRepository _userRepository;
        IMapper _mapper;
        public async Task<IPagedDataResult<GetUserPagedListQueryResponse>> Handle(GetUserPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _userRepository.GetPagedList(request);
            var result = _mapper.Map<IEnumerable<GetUserPagedListQueryResponse>>(data.Data);
            return new PagedDataResult<GetUserPagedListQueryResponse>(data.RecordsTotal, data.RecordsFiltered, result, true, "Başarılı işlem...");
        }

        public GetUserPagedListQueryHandler(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
    }
}
