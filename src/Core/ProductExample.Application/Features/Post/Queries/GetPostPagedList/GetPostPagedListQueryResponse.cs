using Lms.Comman.Domain.Entities;
using Lms.Domain.Entities;
using System;

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
