using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Comment.Queries.GetCommentPagedList
{
    public class GetCommentPagedListQueryHandler : IRequestHandler<GetCommentPagedListQueryRequest, IPagedDataResult<GetCommentPagedListQueryResponse>>
    {
        readonly ICommentRepository _commentRepository;
        IMapper _mapper;
        public GetCommentPagedListQueryHandler(ICommentRepository commentRepository, IMapper mapper)
        {
            _commentRepository = commentRepository;
            _mapper = mapper;
        }
        public async Task<IPagedDataResult<GetCommentPagedListQueryResponse>> Handle(GetCommentPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _commentRepository.GetPagedList(request);
            var result = _mapper.Map<IEnumerable<GetCommentPagedListQueryResponse>>(data.Data);
            return new PagedDataResult<GetCommentPagedListQueryResponse>(data.RecordsTotal, data.RecordsFiltered, result, true, "Başarılı işlem...");
        }
    }
}
