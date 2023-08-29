using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class Teacher : AAuditableEntity<Guid>
    {
        public Teacher()
        {
            Branches = new List<Branch>();
            Educations = new List<Educations>();
        }
        public virtual User User { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Detail { get; set; }
        public string Note { get; set; }
        public virtual IEnumerable<Branch> Branches { get; set; }
        public virtual IEnumerable<Educations> Educations { get; set; }
        public virtual IEnumerable<BookRecommendations> BookRecommendations { get; set; }
        public virtual IEnumerable<Exams> Exams { get; set; }
    }
}
