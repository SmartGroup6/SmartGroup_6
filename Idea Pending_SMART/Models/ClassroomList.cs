using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace Idea_Pending_SMART.Models
{
    public class ClassroomList
    {
        [Key]
        public int? ClassroomID { get; set; }

        public int UserID { get; set; }

        public string ClassDescription { get; set; } = string.Empty;

        public int StudentCount { get; set; }

        public int CourseID { get; set; }

        public int ClassTimeID { get; set; }

        public int SemesterID { get; set; }
    }
}
