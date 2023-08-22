using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Common.Application.Repositories
{
    public interface IBaseRepository
    {
    }
    public interface IBaseRepository<TEntity> : IBaseRepository
    {
    }
}
