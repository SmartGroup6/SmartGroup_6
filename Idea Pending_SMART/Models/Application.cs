using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Idea_Pending_SMART.Models
{
    public class Application
    {
        [Key]
        public int ApplicationID { get; set; }

        
        public float AcademicScore { get; set; }

        public string? DateOfBirth { get; set; }
        
        [Display(Name = "Application")]
        [ConcurrencyCheck]
        public string? ApplicationNameFirst { get; set; }
        [ConcurrencyCheck]
        public string? ApplicationNameLast { get; set; }

        
        public string? Financials { get; set; }
        

        public string? DeterminationNote { get; set; }
        
       
        public string? DistanceNote { get; set; }

       
        public int? InstructorScore { get; set; }

        public int? SocialWorkerScore { get; set; } //Social Worker Score

        public int? AdminScore { get; set; }

        
        public int? TotalScore { get; set; }

        public string? SubmissionDate { get; set; }

        public bool? ChoppaTransportNeeded { get; set; }

        public bool? MealsNeeded { get; set; }
        /*
                [ForeignKey("Applicant")]
                public int ApplicantID { get; set; }

                [ForeignKey("Person")] //required for the guardian if applicable and gets address from guardian
                public int PersonID { get; set; }


        */
    }

}
