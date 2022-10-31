using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Idea_Pending_SMART.Dev_Chantel.Models
{
    public class ClassroomList
    {
        [Key]
        public int? ClassroomID { get; set; }

        public int UserID { get; set; }

        public string ClassDescription { get; set; } = String.Empty;

        public int StudentCount { get; set; }

        public int CourseID { get; set; }

        public int ClassTimeID { get; set; }

        public int SemesterID { get; set; }
    }
}
