using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Idea_Pending_SMART.Models
{
    public class Attendance
    {
        [Key]
        public int AttendanceID { get; set; }

        [Required]
        public DateTime? Date { get; set; }

        [Required]
        public bool? MealProvided { get; set; }

        [Required]
        public char? MealEaten { get; set; }

        [Required]
        [ForeignKey("Enrollment")]
        public int? EnrollmentID { get; set; }

    }

}
