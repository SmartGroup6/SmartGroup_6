using System.ComponentModel.DataAnnotations;

namespace Idea_Pending_SMART.Dev_Chantel.Models
{
    public class ClassTime
    {
        [Key]
        public int ClassTimeID { get; set; }

        public string? Day  { get; set; }
        public DateTime TimeStart { get; set; }
    }
}
