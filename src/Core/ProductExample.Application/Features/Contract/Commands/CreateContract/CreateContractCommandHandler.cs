using AutoMapper;
using FluentValidation;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.UnitOfWork;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Contract.Commands.CreateContract
{
    public class CreateContractCommandHandler : IRequestHandler<CreateContractCommandRequest, IDataResult>
    {
        private readonly IContractRepository _ContractRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateContractCommandRequest> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public CreateContractCommandHandler(IContractRepository ContractRepository, IMapper mapper, IValidator<CreateContractCommandRequest> validator, IUnitOfWork unitOfWork)
        {
            _ContractRepository = ContractRepository;
            _mapper = mapper;
            _validator = validator;
            _unitOfWork = unitOfWork;
        }

        public async Task<IDataResult> Handle(CreateContractCommandRequest request, CancellationToken cancellationToken)
        {
            return new DataResult
            {
                Success = true,
                Message = "Başarıyla eklenmiştir."
            };
        }
    }
}
