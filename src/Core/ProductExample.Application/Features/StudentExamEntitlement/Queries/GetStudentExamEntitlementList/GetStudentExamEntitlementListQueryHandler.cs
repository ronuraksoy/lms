using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.StudentExamEntitlement.Queries.GetStudentExamEntitlementList
{
    public class GetStudentExamEntitlementListQueryHandler : IRequestHandler<GetStudentExamEntitlementListQueryRequest, IDataResult<IEnumerable<GetStudentExamEntitlementListQueryResponse>>>
    {
        readonly IStudentExamEntitlementRepository _studentExamEntitlementRepository;
        IMapper _mapper;
        public GetStudentExamEntitlementListQueryHandler(IStudentExamEntitlementRepository studentExamEntitlementRepository, IMapper mapper)
        {
            _studentExamEntitlementRepository = studentExamEntitlementRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<IEnumerable<GetStudentExamEntitlementListQueryResponse>>> Handle(GetStudentExamEntitlementListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _studentExamEntitlementRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetStudentExamEntitlementListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetStudentExamEntitlementListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
