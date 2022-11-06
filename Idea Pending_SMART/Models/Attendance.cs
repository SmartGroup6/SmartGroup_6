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
<<<<<<< Updated upstream
        [ForeignKey("Class")]
        public int? ClassID { get; set; }

        [Required]
        [ForeignKey("Student")]
        public int StudentID { get; set; }
=======
        [ForeignKey("Enrollment")]
        public int? EnrollmentID { get; set; }

>>>>>>> Stashed changes


    }

}
