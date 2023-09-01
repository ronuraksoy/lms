using AutoMapper;
using FluentValidation;
using Lms.Application.Features.Base;
using Lms.Application.Interfaces.Repositories;
using Lms.Common.Application.UnitOfWork;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Semester.Commands.CreateSemester
{
    public class CreateSemesterCommandHandler : IRequestHandler<CreateSemesterCommandRequest, IDataResult>
    {
        private readonly ISemesterRepository _semesterRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateSemesterCommandRequest> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public CreateSemesterCommandHandler(ISemesterRepository semesterRepository, IMapper mapper, IValidator<CreateSemesterCommandRequest> validator, IUnitOfWork unitOfWork)
        {
            _semesterRepository = semesterRepository;
            _mapper = mapper;
            _validator = validator;
            _unitOfWork = unitOfWork;
        }

        public async Task<IDataResult> Handle(CreateSemesterCommandRequest request, CancellationToken cancellationToken)
        {
            return new DataResult
            {
                Success = true,
                Message = "Başarıyla eklenmiştir."
            };
        }
    }
}
