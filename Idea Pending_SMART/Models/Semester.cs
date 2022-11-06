using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Idea_Pending_SMART.Models
{
    public class Semester
    {
        [Key]
        public int SemesterID { get; set; }

        [Required]
        public string? SemesterName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }

        [Required]
        public bool? IsActiveSemester { get; set; }

        [Required]
        public bool? IsArchived { get; set; }

        [Required]
        public int? MaxStudentCount { get; set; }

        [Required]
        [ForeignKey("School")]
        public int SchoolId { get; set; }
    }

}
