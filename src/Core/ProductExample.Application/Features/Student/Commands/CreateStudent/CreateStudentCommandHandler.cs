using AutoMapper;
using FluentValidation;
using Lms.Application.Features.Base;
using Lms.Application.Features.Student.Commands.CreateStudent;
using Lms.Application.Interfaces.Repositories;
using Lms.Common.Application.UnitOfWork;
using Lms.Common.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Student.Commands.CreateStudent
{
    public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommandRequest, IDataResult>
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateStudentCommandRequest> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public CreateStudentCommandHandler(IStudentRepository studentRepository, IMapper mapper, IValidator<CreateStudentCommandRequest> validator, IUnitOfWork unitOfWork)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
            _validator = validator;
            _unitOfWork = unitOfWork;
        }

        public async Task<IDataResult> Handle(CreateStudentCommandRequest request, CancellationToken cancellationToken)
        {
            return new DataResult
            {
                Success = true,
                Message = "Başarıyla eklenmiştir."
            };
        }
    }
}
