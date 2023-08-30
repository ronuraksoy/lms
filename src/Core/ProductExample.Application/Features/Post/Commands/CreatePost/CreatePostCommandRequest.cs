using Lms.Application.Features.Base;
using Lms.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.Post.Commands.CreatePost
{
    public class CreatePostCommandRequest:BaseRequest
    {
        public DateTime CreatedOn { get; set; }
        public string Message { get; set; }
        public int SenderID { get; set; }
        public User User { get; set; }
    }
}
