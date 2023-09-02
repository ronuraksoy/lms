using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Department.Queries.GetDepartmentPagedList
{
    public class GetDepartmentPagedListQueryHandler : IRequestHandler<GetDepartmentPagedListQueryRequest, IPagedDataResult<GetDepartmentPagedListQueryResponse>>
    {
        readonly IDepartmentRepository _departmentRepository;
        IMapper _mapper;
        public GetDepartmentPagedListQueryHandler(IDepartmentRepository departmentRepository, IMapper mapper)
        {
            _departmentRepository = departmentRepository;
            _mapper = mapper;
        }
        public async Task<IPagedDataResult<GetDepartmentPagedListQueryResponse>> Handle(GetDepartmentPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _departmentRepository.GetPagedList(request);
            var result = _mapper.Map<IEnumerable<GetDepartmentPagedListQueryResponse>>(data.Data);
            return new PagedDataResult<GetDepartmentPagedListQueryResponse>(data.RecordsTotal, data.RecordsFiltered, result, true, "Başarılı işlem...");
        }
    }
}
