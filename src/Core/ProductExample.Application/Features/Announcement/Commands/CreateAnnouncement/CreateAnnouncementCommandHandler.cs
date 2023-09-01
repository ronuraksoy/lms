using AutoMapper;
using FluentValidation;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.UnitOfWork;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Announcement.Commands.CreateAnnouncement
{
    public class CreateAnnouncementCommandHandler : IRequestHandler<CreateAnnouncementCommandRequest, IDataResult>
    {
        private readonly IAnnouncementRepository _announcementRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateAnnouncementCommandRequest> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public CreateAnnouncementCommandHandler(IAnnouncementRepository announcementRepository, IMapper mapper, IValidator<CreateAnnouncementCommandRequest> validator, IUnitOfWork unitOfWork)
        {
            _announcementRepository = announcementRepository;
            _mapper = mapper;
            _validator = validator;
            _unitOfWork = unitOfWork;
        }

        public Task<IDataResult> Handle(CreateAnnouncementCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
