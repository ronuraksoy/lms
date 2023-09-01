using Lms.Domain.Entities;
using System;

namespace Lms.Application.Features.Post.Queries.GetPostById
{
    public class GetPostByIdQueryResponse
    {
        public DateTime CreatedOn { get; set; }
        public string Message { get; set; }
        public int SenderID { get; set; }
        public User User { get; set; }
    }
}
