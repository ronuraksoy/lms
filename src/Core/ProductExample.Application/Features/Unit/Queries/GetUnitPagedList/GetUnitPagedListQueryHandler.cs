using AutoMapper;
using Lms.Application.Features.Teacher.Queries.GetTeacherPagedList;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Unit.Queries.GetUnitPagedList
{
    public class GetUnitPagedListQueryHandler : IRequestHandler<GetUnitPagedListQueryRequest, IPagedDataResult<GetUnitPagedListQueryResponse>>
    {
        readonly IUnitRepository _unitRepository;
        IMapper _mapper;
        public async Task<IPagedDataResult<GetUnitPagedListQueryResponse>> Handle(GetUnitPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _unitRepository.GetPagedList(request);
            var result = _mapper.Map<IEnumerable<GetUnitPagedListQueryResponse>>(data.Data);
            return new PagedDataResult<GetUnitPagedListQueryResponse>(data.RecordsTotal, data.RecordsFiltered, result, true, "Başarılı işlem...");
        }

        public GetUnitPagedListQueryHandler(IUnitRepository unitRepository, IMapper mapper)
        {
            _unitRepository = unitRepository;
            _mapper = mapper;
        }
    }
}
