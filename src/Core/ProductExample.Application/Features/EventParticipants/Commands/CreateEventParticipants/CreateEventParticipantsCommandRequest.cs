using Lms.Application.Features.Base;

namespace Lms.Application.Features.EventParticipants.Commands.CreateEventParticipants
{
    public class CreateEventParticipantsCommandRequest : BaseRequest
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public int? UserID { get; set; }
        public Lms.Domain.Entities.User User { get; set; }
        public int EventID { get; set; }
        public Lms.Domain.Entities.Events Events { get; set; }
    }
}
