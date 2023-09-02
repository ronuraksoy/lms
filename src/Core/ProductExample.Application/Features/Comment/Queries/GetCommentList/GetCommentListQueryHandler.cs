using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Comment.Queries.GetCommentList
{
    public class GetCommentListQueryHandler : IRequestHandler<GetCommentListQueryRequest, IDataResult<IEnumerable<GetCommentListQueryResponse>>>
    {
        readonly ICommentRepository _commentRepository;
        IMapper _mapper;
        public GetCommentListQueryHandler(ICommentRepository commentRepository, IMapper mapper)
        {
            _commentRepository = commentRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<IEnumerable<GetCommentListQueryResponse>>> Handle(GetCommentListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _commentRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetCommentListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetCommentListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
