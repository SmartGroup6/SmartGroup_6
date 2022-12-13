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
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? Date { get; set; }

        [Required]
        public bool? MealProvided { get; set; }

        [Required]
        public char? MealEaten { get; set; }

        [Required]
        public string? student_name { get; set; }
        [Required]
        public string? class_name { get; set; }

        [Required]
        [ForeignKey("Enrollment")]
        public int EnrollmentID { get; set; }

    }

}
