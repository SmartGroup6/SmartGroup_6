using System.ComponentModel.DataAnnotations;

namespace Idea_Pending_SMART.Dev_Chantel.Models
{
    public class Student
    {
        [Key]
        public int? StudentID { get; set; }

        public bool timeAvailable { get; set; }

        public char CurrentGrade { get; set; }

        public int SponsorID { get; set; }

        public int ApplicationID { get; set; }

    }
}
