using AutoMapper;
using FluentValidation;
using Lms.Application.Features.Lessons.Commands.CreateLessons;
using Lms.Application.Features.Notes.Commands.CreateNotes;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.UnitOfWork;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Notification.Commands.CreateNotification
{
    public class CreateNotificationCommandHandler : IRequestHandler<CreateNotificationCommandRequest, IDataResult>
    {

        private readonly INotificationRepository _notificationRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateNotificationCommandRequest> _validator;
        private readonly IUnitOfWork _unitOfWork;
        public CreateNotificationCommandHandler(INotificationRepository notificationRepository, IMapper mapper, IValidator<CreateNotificationCommandRequest> validator, IUnitOfWork unitOfWork)
        {
            _notificationRepository = notificationRepository;
            _mapper = mapper;
            _validator = validator;
            _unitOfWork = unitOfWork;
        }


        public Task<IDataResult> Handle(CreateNotificationCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
