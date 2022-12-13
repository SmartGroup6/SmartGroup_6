using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Idea_Pending_SMART.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public float? AcademicScore { get; set; }

        [Required]
        public bool? timeAvailable { get; set; }

        public String? DateOfBirth { get; set; }

        [Display(Name = "Student")]
        [Required]
        public string? ApplicationNameFirst { get; set; }
        [Required]
        public string? ApplicationNameLast { get; set; }

        public float GPA { get; set; }
        public string? Financials { get; set; }


        public string? DeterminationNote { get; set; }


        public string? DistanceNote { get; set; }


        public int? InstructorScore { get; set; }

        public int? SocialWorkerScore { get; set; } //Social Worker Score

        public int? AdminScore { get; set; }


        public int? TotalScore { get; set; }

        //calculate Age
        public int Age(DateTime DateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Subtract(DateOfBirth).Days;
            age = age / 365;
            return age;
        }

        // [DataType(DataType.Date)]
        // [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        //public DateTime? SubmissionDate { get; set; } = DateTime.Now;

        public String? SubmissionDate { get; set; }
        public bool ChoppaTransportNeeded { get; set; }

        public bool MealsNeeded { get; set; }
       // public bool? IsActive { get; set; }
        /*
                [ForeignKey("Applicant")]
                public int ApplicantID { get; set; }

                [ForeignKey("Person")] //required for the guardian if applicable and gets address from guardian
                public int PersonID { get; set; }


        */

        public float initialScore(float gpa, String income, bool choppa, bool meal)
        {
            float score = 0;

            //GPA
            score += gpa;

            //income
            if (String.Equals(income, "Less than 10,200 MZN"))
            {
                score += 8;
            }
            else if (String.Equals(income, "More than 38,600 MZN"))
            {
                score += 5;
            }
            else
            {
                score += 7;
            }

            //choppa
            if (choppa == false)
            {
                score += 5;
            }
            else
            {
                score += 3;
            }

            //meal
            if (meal == false)
            {
                score += 5;
            }
            else
            {
                score += 3;
            }
            return score;
        }
    }

}
