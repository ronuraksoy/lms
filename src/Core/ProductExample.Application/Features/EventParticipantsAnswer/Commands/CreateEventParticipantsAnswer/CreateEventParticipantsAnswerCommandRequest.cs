using Lms.Application.Features.Base;
using System;

namespace Lms.Application.Features.EventParticipantsAnswer.Commands.CreateEventParticipantsAnswer
{
    public class CreateEventParticipantsAnswerCommandRequest : BaseRequest
    {
        public int EventID { get; set; }
        public Lms.Domain.Entities.Events Events { get; set; }
        public int QuestionID { get; set; }
        public Lms.Domain.Entities.Questions Questions { get; set; }
        public int ParticipantID { get; set; }
        public Lms.Domain.Entities.User User { get; set; }
        public DateTime AnswerDate { get; set; }
        public string Answer { get; set; }
    }
}
