using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Comment.Queries.GetCommentById
{
    public class GetCommentByIdQueryHandler : IRequestHandler<GetCommentByIdQueryRequest, IDataResult<GetCommentByIdQueryResponse>>
    {
        readonly ICommentRepository _commentRepository;
        IMapper _mapper;
        public GetCommentByIdQueryHandler(ICommentRepository commentRepository, IMapper mapper)
        {
            _commentRepository = commentRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<GetCommentByIdQueryResponse>> Handle(GetCommentByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _commentRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetCommentByIdQueryResponse>(data);
            return new DataResult<GetCommentByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
