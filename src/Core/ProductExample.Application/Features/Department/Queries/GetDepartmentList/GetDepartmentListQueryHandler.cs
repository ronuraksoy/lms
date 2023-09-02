using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Department.Queries.GetDepartmentList
{
    public class GetDepartmentListQueryHandler : IRequestHandler<GetDepartmentListQueryRequest, IDataResult<IEnumerable<GetDepartmentListQueryResponse>>>
    {
        readonly IDepartmentRepository _departmentRepository;
        IMapper _mapper;
        public GetDepartmentListQueryHandler(IDepartmentRepository departmentRepository, IMapper mapper)
        {
            _departmentRepository = departmentRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<IEnumerable<GetDepartmentListQueryResponse>>> Handle(GetDepartmentListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _departmentRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetDepartmentListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetDepartmentListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
