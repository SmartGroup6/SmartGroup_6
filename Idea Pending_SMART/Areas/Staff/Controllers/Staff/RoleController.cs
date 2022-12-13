using Idea_Pending_SMART.Areas.Staff.ViewModels;
using Idea_Pending_SMART.Data;
using Idea_Pending_SMART.Interfaces;
using Idea_Pending_SMART.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

[Area("Staff")]
public class RoleController : Controller
{
    private readonly IUnitOfWork _unitOfWork;

    [BindProperty]
    public IdentityRole IdentityRoleObj { get; set; }

    public RoleController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public IActionResult Upsert(string? id)
    {
        IdentityRole SchoolObj = new IdentityRole();
        if (id != null)
        {
            SchoolObj = _unitOfWork.IdentityRole.Get(s => s.Id.Equals(id.ToString()));
            if (SchoolObj == null)
            {
                return NotFound();
            }
        }

        return View(SchoolObj);
    }

    [HttpPost]
    public IActionResult Upsert()
    {
        if (!ModelState.IsValid)
        {
            return View();
        }
        IdentityRoleObj.NormalizedName = IdentityRoleObj.Name.ToUpper();


        IdentityRole exists = _unitOfWork.IdentityRole.Get(s => s.Id.Equals(IdentityRoleObj.Id));

        if (exists == null)
        {
            _unitOfWork.IdentityRole.Add(IdentityRoleObj);
        }
        else
        {
            IdentityRoleObj.ConcurrencyStamp = exists.ConcurrencyStamp;
            _unitOfWork.IdentityRole.Update(IdentityRoleObj);
        }

        _unitOfWork.Commit();
        return RedirectToAction("Roles", "Staff");
    }


    [ActionName("Delete")]
    public IActionResult DeletePost(string? id)
    {
        var objFromDB = _unitOfWork.IdentityRole.Get(m => m.Id.Equals(id));
        if (objFromDB == null)
        {
            return NotFound();
        }
        _unitOfWork.IdentityRole.Delete(objFromDB);
        _unitOfWork.Commit();

        return RedirectToAction("Roles", "Staff");
    }

    public IActionResult Permissions(string? id)
    {
        var vm = new StaffVM();

        var objFromDB = _unitOfWork.IdentityRole.Get(m => m.Id.Equals(id));
        if (objFromDB == null)
        {
            return NotFound();
        }
        vm.IdentityRole = new[] { objFromDB }; //IEnumerable of IdentityRole, use new[] { objFromDB };

        //List of RolePermissions tied to this existing role
        var permissionsFromDb = _unitOfWork.RolePermission.GetAll(m => m.IdentityRoleId.Equals(id));
        vm.RolePermission = permissionsFromDb;

        vm.Permission = _unitOfWork.Permissions.GetAll();
        return View(vm);
    }

    [HttpPost]
    public ActionResult Permissions(IFormCollection form)
    {
        string id = Request.Form["Id"].ToString();
        //Get a list of the permissionId of all selected permissions (ex, [8, 9, 10])
        string selected = Request.Form["permission_select"].ToString();
        string[] selectedList = selected.Split(',');

        //Get last RolePermissiId (very ugly, realistically we should be able to do an sql MAX() call
        int lastId = 0;
        var rps = _unitOfWork.RolePermission.GetAll();
        foreach(var i in rps)
        {
            lastId = i.Id;
        }

        //Delete any RolePermissions that were not checked
        var oldRPs = _unitOfWork.RolePermission.GetAll(m => m.IdentityRoleId.Equals(id));
        foreach( var rp in oldRPs)
        {
            if (!selectedList.Contains(rp.Id.ToString()))
            {
                _unitOfWork.RolePermission.Delete(rp);
            }
            
        }

        //Create and add a RolePermissions for all selected checkboxes
        foreach (var item in selectedList)
        {
            RolePermission role = new RolePermission();
            role.IdentityRoleId = id;
            role.PermissionsId = Int32.Parse(item);
            _unitOfWork.RolePermission.Add(role);
        }
        return RedirectToAction("Roles", "Staff");
    }
}