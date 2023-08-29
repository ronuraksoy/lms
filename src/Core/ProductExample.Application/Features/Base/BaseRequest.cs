using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.Base
{
    public interface BaseRequest : IRequest<IDataResult>
    {

    }
}
