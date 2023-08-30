using AutoMapper;
using Lms.Application.Features.Lessons.Queries.GetLessonsById;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Notification.Queries.GetNotificationById
{
    public class GetNotificationByIdQueryHandler:IRequestHandler<GetNotificationByIdQueryRequest,IDataResult<GetNotificationByIdQueryResponse>>
    {
        readonly INotificationRepository _notificationRepository;
        IMapper _mapper;

        public GetNotificationByIdQueryHandler(INotificationRepository notificationRepository, IMapper mapper)
        {
            _notificationRepository = notificationRepository;
            _mapper = mapper;
        }

        public async Task<IDataResult<GetNotificationByIdQueryResponse>> Handle(GetNotificationByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _notificationRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetNotificationByIdQueryResponse>(data);
            return new DataResult<GetNotificationByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
