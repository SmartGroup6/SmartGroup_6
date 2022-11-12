using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Idea_Pending_SMART.Models
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }

        [Required]
        public string? CourseName { get; set; }

        [Required]
        public string? CourseDescription { get; set; }

        [Required]
        [ForeignKey("School")]
        public int SchoolId { get; set; }


    }

}
