using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Idea_Pending_SMART.Models
{
    public class Application
    {
        [Key]
        public int ApplicationID { get; set; }

        [Required]
        public float AcademicScore { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string? Financials { get; set; }
        
        [Required]
        public string? DeterminationNote { get; set; }
        
        [Required]
        public string? DistanceNote { get; set; }

        [Required]
        public int? InstructorScore { get; set; }

        [Required]
        public int? SocialWorkerScore { get; set; } //Social Worker Score

        [Required]
        public int? AdminScore { get; set; }

        [Required]
        public int? TotalScore { get; set; }

        [Required]
        public DateTime? SubmissionDate { get; set; }

        [Required]
        public bool? ChoppaTransportNeeded { get; set; }

        [Required]
        public bool? MealsNeeded { get; set; }

        [Required]
        [ForeignKey("Applicant")]
        public int ApplicantID { get; set; }


    }

}
