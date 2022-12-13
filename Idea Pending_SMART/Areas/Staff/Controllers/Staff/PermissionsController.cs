using Idea_Pending_SMART.Interfaces;
using Idea_Pending_SMART.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

[Area("Staff")]
public class PermissionsController : Controller
{
    private readonly IUnitOfWork _unitOfWork;

    public PermissionsController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    /////////Upsert stuff
    private readonly IWebHostEnvironment _hostEnvironment;

    //Bind apparently solves some headaches by binding the model to our forum
    [BindProperty]
    public Permissions PermissionsObj { get; set; }


    /*
     * We aren't going to have a separate edit/delete mode. Just upsert.
     * The id is optional, as you either pass it an id that gets edited, or you dont give it an id so it creates a new one.
     * */
    [HttpGet]
    public IActionResult Upsert(int? id) //optional, indicates editing or creating
    {
        Permissions PermissionsO = new Permissions();

        //Get the semester we're editing, if it exists.
        if (id != null)
        {
            PermissionsO = _unitOfWork.Permissions.Get(s => s.PermissionsID == id);
            if (PermissionsO == null)
            {
                return NotFound();
            }
        }

        return View(PermissionsO);
    }


    [HttpPost]
    public IActionResult Upsert() 
    {
        if (!ModelState.IsValid)
        {
            return View();
        }

        if (PermissionsObj.PermissionsID == 0)
        {
            _unitOfWork.Permissions.Add(PermissionsObj);
        }
        else
        {
            _unitOfWork.Permissions.Update(PermissionsObj);
        }

        _unitOfWork.Commit();
        return RedirectToAction("PermsIndex", "Staff");
    }

    [HttpGet]
    public IActionResult Delete(int? id)
    {
        if (id == null || id == 0)
        {
            return NotFound();
        }

        var objFromDb = _unitOfWork.Permissions.Get(m => m.PermissionsID == id);

        if (objFromDb == null)
        {
            return NotFound();
        }

        return View(objFromDb);
    }


    [HttpPost, ActionName("Delete")]
    public IActionResult DeletePost(int? id)
    {
        var objFromDB = _unitOfWork.Permissions.Get(m => m.PermissionsID == id);
        if (objFromDB == null)
        {
            return NotFound();
        }
        _unitOfWork.Permissions.Delete(objFromDB);
        _unitOfWork.Commit();

        return RedirectToAction("PermsIndex", "Staff");
    }
}