using Lms.Application.Features.Base;
using Lms.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.PostLike.Commands.CreatePostLike
{
    public class CreatePostLikeCommandRequest:BaseRequest
    {
        public DateTime CreatedOn { get; set; }
        public int PostID { get; set; }
        public Guid Post { get; set; }
        public int LikedID { get; set; }
        public Guid User { get; set; }
    }
}
