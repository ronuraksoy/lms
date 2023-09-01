using AutoMapper;
using FluentValidation;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.UnitOfWork;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.ExamsQuestionsReport.Commands.CreateExamsQuestionsReport
{
    public class CreateExamsQuestionsCommandHandler : IRequestHandler<CreateExamsQuestionsCommandRequest, IDataResult>
    {
        private readonly IExamsQuestionsReportRepository _examsQuestionsReportRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateExamsQuestionsCommandRequest> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public CreateExamsQuestionsCommandHandler(IExamsQuestionsReportRepository examsQuestionsReportRepository, IMapper mapper, IValidator<CreateExamsQuestionsCommandRequest> validator, IUnitOfWork unitOfWork)
        {
            _examsQuestionsReportRepository = examsQuestionsReportRepository;
            _mapper = mapper;
            _validator = validator;
            _unitOfWork = unitOfWork;
        }

        public async Task<IDataResult> Handle(CreateExamsQuestionsCommandRequest request, CancellationToken cancellationToken)
        {
            return new DataResult
            {
                Success = true,
                Message = "Başarıyla eklenmiştir."
            };
        }
    }
}
