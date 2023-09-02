using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Department.Queries.GetDepartmentById
{
    public class GetDepartmentByIdQueryHandler : IRequestHandler<GetDepartmentByIdQueryRequest, IDataResult<GetDepartmentByIdQueryResponse>>
    {
        readonly IDepartmentRepository _departmentRepository;
        IMapper _mapper;
        public GetDepartmentByIdQueryHandler(IDepartmentRepository departmentRepository, IMapper mapper)
        {
            _departmentRepository = departmentRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<GetDepartmentByIdQueryResponse>> Handle(GetDepartmentByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _departmentRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetDepartmentByIdQueryResponse>(data);
            return new DataResult<GetDepartmentByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
