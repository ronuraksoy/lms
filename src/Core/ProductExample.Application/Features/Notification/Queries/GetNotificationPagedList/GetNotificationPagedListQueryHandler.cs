using AutoMapper;
using Lms.Application.Features.Lessons.Queries.GetLessonsPagedList;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Notification.Queries.GetNotificationPagedList
{
    public class GetNotificationPagedListQueryHandler : IRequestHandler<GetNotificationPagedListQueryRequest, IPagedDataResult<GetNotificationPagedListQueryResponse>>
    {
        readonly INotificationRepository _notificationRepository;
        IMapper _mapper;

        public Task<IPagedDataResult<GetNotificationPagedListQueryResponse>> Handle(GetNotificationPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public GetNotificationPagedListQueryHandler(INotificationRepository notificationRepository, IMapper mapper)
        {
            _notificationRepository = notificationRepository;
            _mapper = mapper;
        }
    }
}
