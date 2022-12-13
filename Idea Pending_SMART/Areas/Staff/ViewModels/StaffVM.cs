using Idea_Pending_SMART.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Idea_Pending_SMART.Areas.Staff.ViewModels
{
    public class StaffVM
    {
        
        //public ManageVM? Manage { get; set; }
        public IEnumerable<Permissions>? Permission { get; set; }
        public IEnumerable<IdentityRole>? IdentityRole { get; set; }
        public IEnumerable<RolePermission>? RolePermission { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }

    }
}
