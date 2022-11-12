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

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? StartDate { get; set; } = DateTime.Now;

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? EndDate { get; set; } = DateTime.Now;

        public bool? IsActiveSemester { get; set; } = false;

        public bool? IsArchived { get; set; } = false;

        public int? MaxStudentCount { get; set; } = 100;

        public int SchoolId { get; set; } = 1;

        [ForeignKey("SchoolId")]
        public virtual School? School { get; set; }
    }

}
