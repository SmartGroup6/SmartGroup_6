using System.ComponentModel.DataAnnotations;

namespace Idea_Pending_SMART.Models
{
    public class ClassTime
    {
        [Key]
        public int ClassTimeID { get; set; }

        [Required]
        public string? Day { get; set; }

        [Required]
        public DateTime? TimeStart { get; set; }


    }

}
