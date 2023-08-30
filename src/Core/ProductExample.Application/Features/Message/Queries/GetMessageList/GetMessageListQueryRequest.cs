using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.Message.Queries.GetMessageList
{
    public class GetMessageListQueryRequest : IRequest<IDataResult<IEnumerable<GetMessageListQueryResponse>>>
    {
    }
}
