using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Educations.Queries.GetEducationsList
{
    public class GetEducationsListQueryHandler : IRequestHandler<GetEducationsListQueryRequest, IDataResult<IEnumerable<GetEducationsListQueryResponse>>>
    {
        readonly IEducationsRepository _educationsRepository;
        IMapper _mapper;
        public GetEducationsListQueryHandler(IEducationsRepository educationsRepository, IMapper mapper)
        {
            _educationsRepository = educationsRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<IEnumerable<GetEducationsListQueryResponse>>> Handle(GetEducationsListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _educationsRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetEducationsListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetEducationsListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
