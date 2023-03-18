using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SEESwebsite.Models
{
    public class IncidentReport
    {
        [Key]
        public int IncidentReportId { get; set; }
        [ForeignKey("Employee")]
        public string EmployeeId { get; set; }
        public DateTime IncidentDate { get; set; }
        public int EventId { get; set; }
        public string Subject { get; set; }
        public string ReportDetails { get; set; }
        public bool WasReviewed { get; set; }
    }
}
