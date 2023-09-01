using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Admin.Queries.GetAdminPagedList
{
    public class GetAdminPagedListQueryHandler : IRequestHandler<GetAdminPagedListQueryRequest, IPagedDataResult<GetAdminPagedListQueryResponse>>
    {
        readonly IAdminRepository _adminRepository;
        IMapper _mapper;
        public Task<IPagedDataResult<GetAdminPagedListQueryResponse>> Handle(GetAdminPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public GetAdminPagedListQueryHandler(IAdminRepository adminRepository, IMapper mapper)
        {
            _adminRepository = adminRepository;
            _mapper = mapper;
        }
    }
}
