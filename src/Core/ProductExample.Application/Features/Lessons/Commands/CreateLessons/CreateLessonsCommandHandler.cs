using AutoMapper;
using FluentValidation;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.UnitOfWork;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Lessons.Commands.CreateLessons
{
    public class CreateLessonsCommandHandler : IRequestHandler<CreateLessonsCommandRequest, IDataResult>
    {

        private readonly ILessonsRepository _lessonsRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateLessonsCommandRequest> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public CreateLessonsCommandHandler(ILessonsRepository lessonsRepository, IMapper mapper, IValidator<CreateLessonsCommandRequest> validator, IUnitOfWork unitOfWork)
        {
            _lessonsRepository = lessonsRepository;
            _mapper = mapper;
            _validator = validator;
            _unitOfWork = unitOfWork;
        }

        public Task<IDataResult> Handle(CreateLessonsCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
