using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Idea_Pending_SMART.Models
{
    public class Permissions
    {
        [Key]
        public int PermissionsID { get; set; }

        [Required]
        public string? PermissionsName { get; set; }

    }

}
