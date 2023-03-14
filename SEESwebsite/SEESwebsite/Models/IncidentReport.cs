namespace SEESwebsite.Models
{
    public class IncidentReport
    {
        public int ReportId { get; set; }
        public Employee Employee { get; set; }
        public DateTime IncidentDate { get; set; }
        public Event Event { get; set; }
        public string Subject { get; set; }
        public string ReportDetails { get; set; }
        public bool WasReviewed { get; set; }
    }
}
