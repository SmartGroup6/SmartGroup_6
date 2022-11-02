using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Idea_Pending_SMART.Models
{
    public class Role
    {
        [Key]
        public int RoleID { get; set; }

        [Required]
        public string? RoleName { get; set; }

        [Required]
        [ForeignKey("Permissions")]
        public int? PermissionsID { get; set; }



    }

}
