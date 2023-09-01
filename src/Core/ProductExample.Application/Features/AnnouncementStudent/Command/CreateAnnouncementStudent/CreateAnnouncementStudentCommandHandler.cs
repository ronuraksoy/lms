using AutoMapper;
using FluentValidation;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.UnitOfWork;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.AnnouncementStudent.Commands.CreateAnnouncementStudent
{
    public class CreateAnnouncementStudentCommandHandler : IRequestHandler<CreateAnnouncementStudentCommandRequest, IDataResult>
    {
        private readonly IAnnouncementStudentRepository _announcementStudentRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateAnnouncementStudentCommandRequest> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public CreateAnnouncementStudentCommandHandler(IAnnouncementStudentRepository announcementStudentRepository, IMapper mapper, IValidator<CreateAnnouncementStudentCommandRequest> validator, IUnitOfWork unitOfWork)
        {
            _announcementStudentRepository = announcementStudentRepository;
            _mapper = mapper;
            _validator = validator;
            _unitOfWork = unitOfWork;
        }

        public Task<IDataResult> Handle(CreateAnnouncementStudentCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
