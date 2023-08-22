using Lms.Common.Application.Dtos.Datatables;
using Lms.Common.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.Teacher.Queries
{
    public class GetTeacherPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetTeacherPagedListQueryResponse>>
    {
        public string? NameFilter { get; set; }
    }
}
