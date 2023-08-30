using Lms.Comman.Domain.Entities;
using Lms.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.Post.Queries.GetPostPagedList
{
    public class GetPostPagedListQueryResponse: AAuditableEntity<Guid>
    {
        public DateTime CreatedOn { get; set; }
        public string Message { get; set; }
        public int SenderID { get; set; }
        public  User User { get; set; }
    }
}
