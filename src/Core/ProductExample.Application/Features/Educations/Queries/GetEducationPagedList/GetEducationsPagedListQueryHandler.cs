using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Educations.Queries.GetEducationsPagedList
{
    public class GetEducationsPagedListQueryHandler : IRequestHandler<GetEducationsPagedListQueryRequest, IPagedDataResult<GetEducationsPagedListQueryResponse>>
    {
        readonly IEducationsRepository _educationsRepository;
        IMapper _mapper;
        public GetEducationsPagedListQueryHandler(IEducationsRepository educationsRepository, IMapper mapper)
        {
            _educationsRepository = educationsRepository;
            _mapper = mapper;
        }
        public async Task<IPagedDataResult<GetEducationsPagedListQueryResponse>> Handle(GetEducationsPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _educationsRepository.GetPagedList(request);
            var result = _mapper.Map<IEnumerable<GetEducationsPagedListQueryResponse>>(data.Data);
            return new PagedDataResult<GetEducationsPagedListQueryResponse>(data.RecordsTotal, data.RecordsFiltered, result, true, "Başarılı işlem...");
        }
    }
}
