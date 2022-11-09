using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Idea_Pending_SMART.Models
{
    public class User
    {

        //Likely will be reworked when Dr. Fry teaches us how to add login systems
        [Key]
        public int UserID { get; set; }

        [Required]
        public string? EmailAddress { get; set; }

        [Required]
        public string? Password { get; set; }

        [Required]
        [ForeignKey("Role")]
        public int? RoleID { get; set; }

        [Required]
        [ForeignKey("Person")]
        public int PersonID { get; set; }


    }

}
