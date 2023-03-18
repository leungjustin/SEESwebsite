using System.ComponentModel.DataAnnotations;

namespace SEESwebsite.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }
        public string EventName { get; set; }
        public DateTime EventStartDate { get; set; }
        public DateTime EventEndDate { get; set; }
        public Venue Venue { get; set; }
        public string EventNotes { get; set; }
        public ICollection<Shift> Shifts { get; set; }
        public ICollection<IncidentReport> IncidentReports { get; set; }

    }
}
