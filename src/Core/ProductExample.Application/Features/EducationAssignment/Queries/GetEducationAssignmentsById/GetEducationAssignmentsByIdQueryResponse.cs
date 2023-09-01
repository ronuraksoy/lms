using System;

namespace Lms.Application.Features.EducationAssignments.Queries.GetEducationAssignmentsById
{
    public class GetEducationAssignmentsByIdQueryResponse
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int OfferedCourseId { get; set; }
        public string FilePath { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
