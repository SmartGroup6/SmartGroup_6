using System.ComponentModel.DataAnnotations;

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
