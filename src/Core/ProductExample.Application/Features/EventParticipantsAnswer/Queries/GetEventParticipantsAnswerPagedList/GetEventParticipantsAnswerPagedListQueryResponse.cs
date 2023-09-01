﻿using Lms.Comman.Domain.Entities;
using System;

namespace Lms.Application.Features.EventParticipantsAnswer.Queries.GetEventParticipantsAnswerPagedList
{
    public class GetEventParticipantsAnswerPagedListQueryResponse : AAuditableEntity<Guid> //Tabloda görünmesini istediğimiz bilgiler
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
