using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Idea_Pending_SMART.Models
{
    public class ClassTime
    {
        [Key]
        public int ClassTimeID { get; set; }

        [Required]
        public string? Day { get; set; }

        [Required]
        public string? TimeStart { get; set; }


    }

}
