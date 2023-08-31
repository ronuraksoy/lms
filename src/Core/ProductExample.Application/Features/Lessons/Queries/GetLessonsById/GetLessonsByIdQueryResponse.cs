using Lms.Domain.Entities;
using System;

namespace Lms.Application.Features.Lessons.Queries.GetLessonsById
{
    public class GetLessonsByIdQueryResponse
    {
        public string Name { get; set; }
        public string Note { get; set; }
        public string ImagePath { get; set; }
        public int Hour { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Certificate { get; set; }
        public int CategoriesID { get; set; }
        //public Category Category { get; set; }
        public int DepartmentID { get; set; }
        public Department Department { get; set; }
    }
}
