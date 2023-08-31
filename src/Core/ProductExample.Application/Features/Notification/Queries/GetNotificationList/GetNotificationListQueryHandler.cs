using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Notification.Queries.GetNotificationList
{
    public class GetNotificationListQueryHandler : IRequestHandler<GetNotificationListQueryRequest, IDataResult<IEnumerable<GetNotificationListQueryResponse>>>
    {
        readonly INotificationRepository _notificationRepository;
        IMapper _mapper;

        public GetNotificationListQueryHandler(IMapper mapper, INotificationRepository notificationRepository)
        {
            _mapper = mapper;
            _notificationRepository = notificationRepository;
        }

        public async Task<IDataResult<IEnumerable<GetNotificationListQueryResponse>>> Handle(GetNotificationListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _notificationRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetNotificationListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetNotificationListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
