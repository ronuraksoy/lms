using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class Document : AAuditableEntity<Guid>
    {
        public int EducationID { get; set; }
        public virtual Educations Educations { get; set; }
        public string PdfPath { get; set; }
    }
}
