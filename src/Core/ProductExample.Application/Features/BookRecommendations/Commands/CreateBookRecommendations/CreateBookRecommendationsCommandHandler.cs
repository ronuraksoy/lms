using AutoMapper;
using FluentValidation;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.UnitOfWork;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.BookRecommendations.Commands.CreateBookRecommendations
{
    public class CreateBookRecommendationsCommandHandler : IRequestHandler<CreateBookRecommendationsCommandRequest, IDataResult>
    {
        private readonly IBookRecommendationsRepository _BookRecommendationsRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateBookRecommendationsCommandRequest> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public CreateBookRecommendationsCommandHandler(IBookRecommendationsRepository BookRecommendationsRepository, IMapper mapper, IValidator<CreateBookRecommendationsCommandRequest> validator, IUnitOfWork unitOfWork)
        {
            _BookRecommendationsRepository = BookRecommendationsRepository;
            _mapper = mapper;
            _validator = validator;
            _unitOfWork = unitOfWork;
        }

        public async Task<IDataResult> Handle(CreateBookRecommendationsCommandRequest request, CancellationToken cancellationToken)
        {
            return new DataResult
            {
                Success = true,
                Message = "Başarıyla eklenmiştir."
            };
        }
    }
}
