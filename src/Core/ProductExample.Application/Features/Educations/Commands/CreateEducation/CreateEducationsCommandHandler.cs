using AutoMapper;
using FluentValidation;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.UnitOfWork;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Educations.Commands.CreateEducations
{
    public class CreateEducationsCommandHandler : IRequestHandler<CreateEducationsCommandRequest, IDataResult>
    {
        private readonly IEducationsRepository _educationsRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateEducationsCommandRequest> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public CreateEducationsCommandHandler(IEducationsRepository educationsRepository, IMapper mapper, IValidator<CreateEducationsCommandRequest> validator, IUnitOfWork unitOfWork)
        {
            _educationsRepository = educationsRepository;
            _mapper = mapper;
            _validator = validator;
            _unitOfWork = unitOfWork;
        }

        public async Task<IDataResult> Handle(CreateEducationsCommandRequest request, CancellationToken cancellationToken)
        {
            return new DataResult
            {
                Success = true,
                Message = "Başarıyla eklenmiştir."
            };
        }
    }
}
