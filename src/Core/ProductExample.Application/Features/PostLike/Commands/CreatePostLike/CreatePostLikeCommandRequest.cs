using Lms.Application.Features.Base;
using System;

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
