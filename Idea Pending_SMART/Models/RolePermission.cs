using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Idea_Pending_SMART.Models
{
    //Bridge model between permissions and roles
    public class RolePermission
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("IdentityRole")]
        public string IdentityRoleId { get; set; }
        public IdentityRole IdentityRole { get; set; }

        [ForeignKey("Permissions")]
        public int PermissionsId { get; set; }
        public virtual Permissions Permissions { get; set; }

    }

}
