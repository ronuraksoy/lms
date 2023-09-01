using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Classrooms.Queries.GetClassroomsPagedList
{
    public class GetClassroomsPagedListQueryHandler : IRequestHandler<GetClassroomsPagedListQueryRequest, IPagedDataResult<GetClassroomsPagedListQueryResponse>>
    {
        readonly IClassroomsRepository _classroomsRepository;
        IMapper _mapper;
        public GetClassroomsPagedListQueryHandler(IClassroomsRepository classroomsRepository, IMapper mapper)
        {
            _classroomsRepository = classroomsRepository;
            _mapper = mapper;
        }
        public async Task<IPagedDataResult<GetClassroomsPagedListQueryResponse>> Handle(GetClassroomsPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _classroomsRepository.GetPagedList(request);
            var result = _mapper.Map<IEnumerable<GetClassroomsPagedListQueryResponse>>(data.Data);
            return new PagedDataResult<GetClassroomsPagedListQueryResponse>(data.RecordsTotal, data.RecordsFiltered, result, true, "Başarılı işlem...");
        }
    }
}
