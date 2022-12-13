using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.Extensions.Configuration.UserSecrets;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Idea_Pending_SMART.Models
{
    public class Class //AKA Section
    {
        [Key]
        public int ClassID { get; set; }

        [Required]
        [Display(Name = "Class Description")]
        public string? ClassDescription { get; set; }

        [Display(Name = "Student Count:")]
        [Required]
        public int Studentcount { get; set; }


        [ForeignKey("Course")]
        public int CourseID { get; set; }

        [ForeignKey("ClassTime")]
        [Display(Name = "ClassTime")]
        public int ClassTimeID { get; set; }


        [ForeignKey("Semester")]
        public int SemesterID { get; set; }
        public string ApplicationUserId { get; set; }
        [ForeignKey("ApplicationUserId")]

        [ValidateNever]
        public ApplicationUser ApplicationUser { get; set; }


        [ForeignKey("ClassTimeID")]
        public virtual ClassTime? ClassTime { get; set; }
        [ForeignKey("SemesterID")]
        public virtual Semester? Semester { get; set; }
        [ForeignKey("CourseID")]
        public virtual Course? Course { get; set; }

        //testing
        //  public List<Enrollment> Enrollments { get; set; }

    }

}