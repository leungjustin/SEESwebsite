namespace SEESwebsite.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string EventName { get; set; }
        public DateTime EventStartDate { get; set; }
        public DateTime EventEndDate { get; set; }
        public Venue Venue { get; set; }
        public string EventNotes { get; set; }

    }
}
