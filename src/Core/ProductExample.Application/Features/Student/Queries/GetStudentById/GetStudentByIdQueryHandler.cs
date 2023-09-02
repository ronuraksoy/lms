using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Student.Queries.GetStudentById
{
    public class GetStudentByIdQueryHandler : IRequestHandler<GetStudentByIdQueryRequest, IDataResult<GetStudentByIdQueryResponse>>
    {
        readonly IStudentRepository _studentRepository;
        IMapper _mapper;
        public GetStudentByIdQueryHandler(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<GetStudentByIdQueryResponse>> Handle(GetStudentByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _studentRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetStudentByIdQueryResponse>(data);
            return new DataResult<GetStudentByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
