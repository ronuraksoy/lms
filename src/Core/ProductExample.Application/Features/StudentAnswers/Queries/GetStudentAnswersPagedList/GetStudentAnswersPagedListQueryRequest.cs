using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.StudentAnswers.Queries.GetStudentAnswersPagedList
{
    public class GetStudentAnswersPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetStudentAnswersPagedListQueryResponse>>
    {
    }
}
