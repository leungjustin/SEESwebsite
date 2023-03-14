
namespace SEESwebsite.Models
{
    public class Shift
    {
        //PRIMARY KEY
        public int ShiftId { get; set; }
        //OTHER PROPERTIES
        public DateTime ShiftStartTime { get; set; }
        public DateTime ShiftEndTime { get; set; }
        //public Event Event {get; set;} //Event not yet implemented
        public Employee Employee {get; set;} //Employee not yet implemented
    }
}
