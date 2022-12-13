using Humanizer;
using Microsoft.AspNetCore.Mvc;
using static Humanizer.In;
using System.Security.Claims;
using Idea_Pending_SMART.Interfaces;
using Idea_Pending_SMART.Models;

namespace Idea_Pending_SMART.ViewComponents
{
    public class SidebarViewComponent : ViewComponent
    {
        private readonly IUnitOfWork _unitOfWork;
        //private readonly IWebHostEnvironment _hostEnvironment;

        [BindProperty]
        public RolePermission RolePermObj { get; set; }

        public SidebarViewComponent(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Task<IViewComponentResult> InvokeAsync()
        {
            List<Permissions> AvailablePerms = new List<Permissions>();
            //Get user ID
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            if(!claimsIdentity.IsAuthenticated)
            {
                return Task.FromResult<IViewComponentResult>(View("_Sidebar", AvailablePerms));
            }
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            var LoggedInUser = _unitOfWork.ApplicationUser.Get(a => a.Id == claim.Value);
            var UserRole = _unitOfWork.IdentityUserRole.Get(b => b.UserId.Equals(LoggedInUser.Id));

            //Now we have our RolePermissions
            IEnumerable<RolePermission> RolePerms = _unitOfWork.RolePermission.GetAll(i => i.IdentityRoleId.Equals(UserRole.RoleId));

            //And let's get a list of our actual permissions.
            
            foreach( var rp in RolePerms)
            {
                AvailablePerms.Add(_unitOfWork.Permissions.Get(i => i.PermissionsID.Equals(rp.PermissionsId)));
            }

            return Task.FromResult<IViewComponentResult>(View("_Sidebar", AvailablePerms));
        }

    }
}
