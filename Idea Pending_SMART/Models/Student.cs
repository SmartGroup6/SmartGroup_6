using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Idea_Pending_SMART.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }

        [Required]
        public bool? timeAvailable { get; set; }

        [Required]
        public char? CurrentGrade { get; set; }

        //NOT required
        [ForeignKey("Sponsor")]
        public int? SponsorID { get; set; }

        [Required]
        [ForeignKey("Applicant")]
        public int ApplicantID { get; set; }



    }

}
