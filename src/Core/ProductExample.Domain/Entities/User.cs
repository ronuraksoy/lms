using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public enum UserType
    {
        Student,
        Teacher,
        Admin
    }
    public class User : AAuditableEntity<Guid>
    {
        public User()
        {
            CreatedChats = new List<Chat>();
            ReceiverChats = new List<Chat>();
            SendMessages = new List<Message>();
            ReceiveMessages = new List<Message>();
        }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual IEnumerable<Chat> CreatedChats { get; set; }
        public virtual IEnumerable<Chat> ReceiverChats { get; set; }
        public virtual IEnumerable<Message> SendMessages { get; set; }
        public virtual IEnumerable<Message> ReceiveMessages { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Student Student { get; set; }
        public virtual Admin Admin { get; set; }
        public UserType? Type { get; set; }
        public string Image { get; set; }
        public virtual IEnumerable<Announcement> Announcements { get; set; }
        public virtual IEnumerable<Comment> Comments { get; set; }
        public virtual IEnumerable<EventParticipants> EventParticipants { get; set; }
        public virtual IEnumerable<EventParticipantsAnswer> EventParticipantsAnswers { get; set; }
        public virtual IEnumerable<Post> Posts { get; set; }
        public virtual IEnumerable<PostLike> PostLikes { get; set; }
        public virtual IEnumerable<Notification> Notifications { get; set; }
        public virtual IEnumerable<Forum> Forums{ get; set; }
    }
}
