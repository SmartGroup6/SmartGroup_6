using Idea_Pending_SMART.Areas.Semester.ViewModels;
using Idea_Pending_SMART.Areas.Staff.ViewModels;
using Idea_Pending_SMART.Interfaces;
using Idea_Pending_SMART.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

[Area("Staff")]
public class StaffController : Controller
{
    private readonly IUnitOfWork _unitOfWork;
    public StaffController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    //ctrl+k+c to comment, ctrl+k+u to uncomment
    public ViewResult Index()
    {
        IEnumerable<ApplicationUser> objList = _unitOfWork.ApplicationUser.GetAll();

        return View(objList);
    }

    public ViewResult Roles()
    {
        IEnumerable<IdentityRole> objList = _unitOfWork.IdentityRole.GetAll();

        //StaffVM staff = new StaffVM();

        //staff.IdentityRole = _unitOfWork.IdentityRole.GetAll();


        return View(objList);
    }


    public ViewResult PermsIndex()
    {
        IEnumerable<Permissions> objList = _unitOfWork.Permissions.GetAll();

        return View(objList);
    }

}