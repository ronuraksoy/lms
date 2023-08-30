using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.Notes.Queries.GetNotesPagedList
{
    public class GetNotesPagedListQueryRequest:DtParameters,IRequest<IPagedDataResult<GetNotesPagedListQueryResponse>>
    {
    }
}
