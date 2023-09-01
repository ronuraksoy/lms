﻿using Lms.Comman.Domain.Entities;
using System;

namespace Lms.Application.Features.ExamsQuestionsReport.Queries.GetExamsQuestionsReportPagedList
{
    public class GetExamsQuestionsPagedListQueryResponse : AAuditableEntity<Guid> //Tabloda görünmesini istediğimiz bilgiler
    {
        public int ExamsID { get; set; }
        public Lms.Domain.Entities.Exams Exams { get; set; }
        public int QuestionsID { get; set; }
        public Lms.Domain.Entities.Questions Questions { get; set; }
        public int StudentID { get; set; }
        public Lms.Domain.Entities.Student Student { get; set; }
        public DateTime DateTime { get; set; }
    }
}
