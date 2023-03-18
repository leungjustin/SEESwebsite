
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SEESwebsite.Models
{
    public class Shift
    {
        [Key]
        public int ShiftId { get; set; }
        //OTHER PROPERTIES
        public DateTime ShiftStartTime { get; set; }
        public DateTime ShiftEndTime { get; set; }
        public int EventId {get; set;}
        [ForeignKey("Employee")]
        public string EmployeeId {get; set;}
    }
}
