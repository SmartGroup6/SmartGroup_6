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
<<<<<<< Updated upstream
        public float AcademicScore { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }
=======
        public string? ApplicationNameFirst { get; set; }

        [Required]
        public string? ApplicationNameLast { get; set; }



        [Required]
        public float AcademicScore { get; set; }

        [Required]
        public string? DateOfBirth { get; set; }
>>>>>>> Stashed changes

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
<<<<<<< Updated upstream
        public DateTime? SubmissionDate { get; set; }
=======
        public string? SubmissionDate { get; set; }
>>>>>>> Stashed changes

        [Required]
        public bool? ChoppaTransportNeeded { get; set; }

        [Required]
        public bool? MealsNeeded { get; set; }

        [Required]
        [ForeignKey("Applicant")]
        public int ApplicantID { get; set; }

<<<<<<< Updated upstream
=======
        [ForeignKey("Person")] //required for the guardian if applicable and gets address from guardian
        public int PersonID { get; set; }

>>>>>>> Stashed changes

    }

}
