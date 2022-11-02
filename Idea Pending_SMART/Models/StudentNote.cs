using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Idea_Pending_SMART.Models
{
    public class StudentNote
    {
        [Key]
        public int StudentNoteID { get; set; }

        [Required]
        public string? Text { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }


    }

}
