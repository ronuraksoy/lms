using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.StudentQuestions.Queries.GetStudentQuestionsPagedList
{
    public class GetStudentQuestionsPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetStudentQuestionsPagedListQueryResponse>>
    {
    }
}
