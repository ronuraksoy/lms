using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Student.Queries.GetStudentList
{
    public class GetStudentListQueryHandler : IRequestHandler<GetStudentListQueryRequest, IDataResult<IEnumerable<GetStudentListQueryResponse>>>
    {
        readonly IStudentRepository _studentRepository;
        IMapper _mapper;
        public GetStudentListQueryHandler(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<IEnumerable<GetStudentListQueryResponse>>> Handle(GetStudentListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _studentRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetStudentListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetStudentListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
