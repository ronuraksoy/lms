using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class Student : AAuditableEntity<Guid>
    {
        public Student()
        {
            Categories = new List<Category>();
            Customers = new List<Customer>();

        }
        public virtual User User { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public int SchoolID { get; set; }
        public string Grade { get; set; }
        [DefaultValue("/assets/media/users/default.jpg")]
        public string Logo { get; set; }
        public virtual IEnumerable<Category> Categories { get; set; }
        public virtual IEnumerable<Customer> Customers { get; set; }
        public virtual IEnumerable<AssignmentResult> AssignmentResults { get; set; }
        public virtual IEnumerable<ExamsQuestionsReport> ExamsQuestionsReports { get; set; }
        public virtual IEnumerable<Notes> Notes { get; set; }
        public virtual IEnumerable<StudentAnswers> StudentAnswers { get; set; }
        public virtual IEnumerable<StudentAssignments> StudentAssignments { get; set; }
        public virtual IEnumerable<StudentExamEntitlement> StudentExamEntitlements { get; set; }
        public virtual IEnumerable<StudentExamLogs> StudentExamLogs { get; set; }
        public virtual IEnumerable<StudentQuestions> StudentQuestions { get; set; }
    }
}
