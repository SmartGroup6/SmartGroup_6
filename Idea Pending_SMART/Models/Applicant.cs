using System.ComponentModel.DataAnnotations;

namespace Idea_Pending_SMART.Models
{
    public class Applicant
    {
        [Key]
        public int ApplicantID { get; set; }

        [Required]
        public string? AppStatus { get; set; }


    }

}
