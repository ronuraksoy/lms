using Lms.Comman.Domain.Entities;
using Lms.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.Lessons.Queries.GetLessonsPagedList
{
    public class GetLessonsPagedListQueryResponse:AAuditableEntity<Guid>
    {
        public string Name { get; set; }
        public string Note { get; set; }
        public string ImagePath { get; set; }
        public int Hour { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Certificate { get; set; }
        public int CategoriesID { get; set; }
        public Lms.Domain.Entities.Category Category { get; set; }
        public int DepartmentID { get; set; }
        public Department Department { get; set; }
    }
}
