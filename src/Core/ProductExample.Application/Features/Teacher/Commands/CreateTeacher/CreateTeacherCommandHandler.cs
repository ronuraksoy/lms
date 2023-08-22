using AutoMapper;
using FluentValidation;
using Lms.Application.Features.Base;
using Lms.Application.Interfaces.Repositories;
using Lms.Application.Interfaces.UnitOfWork;
using Lms.Common.Application.UnitOfWork;
using Lms.Common.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Teacher.Commands.CreateTeacher
{
    public class CreateTeacherCommandHandler : IRequestHandler<CreateTeacherCommandRequest, IDataResult>
    {
        private readonly ITeacherRepository _teacherRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateTeacherCommandRequest> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public CreateTeacherCommandHandler(ITeacherRepository teacherRepository, IMapper mapper, IValidator<CreateTeacherCommandRequest> validator, IUnitOfWork unitOfWork)
        {
            _teacherRepository = teacherRepository;
            _mapper = mapper;
            _validator = validator;
            _unitOfWork = unitOfWork;
        }

        public async Task<IDataResult> Handle(CreateTeacherCommandRequest request, CancellationToken cancellationToken)
        {
            return new DataResult
            {
                Success = true,
                Message = "Başarıyla eklenmiştir."
            };
        }
    }
}
