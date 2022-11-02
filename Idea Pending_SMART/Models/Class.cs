using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Idea_Pending_SMART.Models
{
    public class Class //AKA Section
    {
        [Key]
        public int ClassID { get; set; }

        [Required]
        [ForeignKey("Student")]
        public int? StudentID { get; set; }

        [Required]
        public string? ClassDescription { get; set; }

        [Required]
        public int? Studentcount { get; set; }

        [Required]
        [ForeignKey("Course")]
        public int CourseID { get; set; }

        [Required]
        [ForeignKey("ClassTime")]
        public int ClassTimeID { get; set; }

        [Required]
        [ForeignKey("Semester")]
        public int SemesterID { get; set; }
    }

}
