using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Idea_Pending_SMART.Models
{
    public class Class //AKA Section
    {
        [Key]
        public int ClassID { get; set; }

        [Required]
        [Display(Name = "Class Description")]
        public string? ClassDescription { get; set; }

        [Display(Name = "Student Count:")]
        [Required]
        public int Studentcount { get; set; }

        [Required]
        [ForeignKey("Course")]
        public int CourseID { get; set; }

        [Required]
        [ForeignKey("ClassTime")]
        [Display(Name = "ClassTime")]
        public int ClassTimeID { get; set; }

        [Required]
        [ForeignKey("Semester")]
        public int SemesterID { get; set; }

        [Display(Name = "UserID")]
        [ForeignKey("User")]
        public int? UserID { get; set; }
        [ForeignKey("ClassTimeID")]
        public virtual ClassTime? ClassTime { get; set; }

        //testing
        public List<Enrollment> Enrollments { get; set; }

    }

}