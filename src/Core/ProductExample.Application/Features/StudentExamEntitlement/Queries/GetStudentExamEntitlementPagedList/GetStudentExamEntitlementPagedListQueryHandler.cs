using AutoMapper;
using Lms.Application.Features.Teacher.Queries.GetTeacherPagedList;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.StudentExamEntitlement.Queries.GetStudentExamEntitlementPagedList
{
    public class GetStudentExamEntitlementPagedListQueryHandler : IRequestHandler<GetStudentExamEntitlementPagedListQueryRequest, IPagedDataResult<GetStudentExamEntitlementPagedListQueryResponse>>
    {
        readonly IStudentExamEntitlementRepository _studentExamEntitlementRepository;
        IMapper _mapper;
        public async Task<IPagedDataResult<GetStudentExamEntitlementPagedListQueryResponse>> Handle(GetStudentExamEntitlementPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _studentExamEntitlementRepository.GetPagedList(request);
            var result = _mapper.Map<IEnumerable<GetStudentExamEntitlementPagedListQueryResponse>>(data.Data);
            return new PagedDataResult<GetStudentExamEntitlementPagedListQueryResponse>(data.RecordsTotal, data.RecordsFiltered, result, true, "Başarılı işlem...");
        }

        public GetStudentExamEntitlementPagedListQueryHandler(IStudentExamEntitlementRepository studentExamEntitlementRepository, IMapper mapper)
        {
            _studentExamEntitlementRepository = studentExamEntitlementRepository;
            _mapper = mapper;
        }
    }
}
