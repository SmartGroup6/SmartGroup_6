using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Idea_Pending_SMART.Models
{
    public class Applicant
    {
        [Key]
        public int ApplicantID { get; set; }

        [Required]
        public string? AppStatus { get; set; }

        [Required]
<<<<<<< Updated upstream
        [ForeignKey("Student")]
        public int? StudentID { get; set; }

        [Required]
=======
>>>>>>> Stashed changes
        [ForeignKey("Application")]
        public int ApplicationID { get; set; }


    }

}
