using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.StudentExamEntitlement.Queries.GetStudentExamEntitlementById
{
    public class GetStudentExamEntitlementByIdQueryHandler : IRequestHandler<GetStudentExamEntitlementByIdQueryRequest, IDataResult<GetStudentExamEntitlementByIdQueryResponse>>
    {
        readonly IStudentExamEntitlementRepository _studentExamEntitlementRepository;
        IMapper _mapper;
        public GetStudentExamEntitlementByIdQueryHandler(IStudentExamEntitlementRepository studentExamEntitlementRepository, IMapper mapper)
        {
            _studentExamEntitlementRepository = studentExamEntitlementRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<GetStudentExamEntitlementByIdQueryResponse>> Handle(GetStudentExamEntitlementByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _studentExamEntitlementRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetStudentExamEntitlementByIdQueryResponse>(data);
            return new DataResult<GetStudentExamEntitlementByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
