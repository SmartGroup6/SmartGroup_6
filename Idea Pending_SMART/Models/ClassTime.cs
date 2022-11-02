using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Idea_Pending_SMART.Models
{
    public class Classtime
    {
        [Key]
        public int ClassTimeID { get; set; }

        [Required]
        public string? Day { get; set; }

        [Required]
        public DateTime? TimeStart { get; set; }


    }

}
