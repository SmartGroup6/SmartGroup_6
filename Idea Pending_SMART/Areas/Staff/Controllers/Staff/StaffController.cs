using Idea_Pending_SMART.Interfaces;
using Idea_Pending_SMART.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

[Area("Staff")]
public class StaffController : Controller
{
    private readonly IUnitOfWork _unitOfWork;
    /*
        +CreateGrade(GradeID, StudentID, LetterGrade, Percent, Pass)
        +UpdateGrade(StudentID,LetterGrade)
        +AddAttendance
        +AddNotes
        +Meals
        * */

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

    /////////Upsert stuff
    //private readonly IWebHostEnvironment _hostEnvironment;

    //Bind apparently solves some headaches by binding the model to our forum
    [BindProperty]
    public ApplicationUser ApplicationUserObj { get; set; }


    /*
     * We aren't going to have a separate edit/delete mode. Just upsert.
     * The id is optional, as you either pass it an id that gets edited, or you dont give it an id so it creates a new one.
     * */
    [HttpGet]
    public IActionResult Upsert(int? id) //optional, indicates editing or creating
    {
        ApplicationUser ApplicationUserObj = new ApplicationUser();

        if (id != null)
        {
            ApplicationUserObj = _unitOfWork.ApplicationUser.Get(s => Int32.Parse(s.ApplicationUserId) == id);
            if (ApplicationUserObj == null)
            {
                return NotFound();
            }
        }

        return View(ApplicationUserObj);
    }


    [HttpPost]
    public IActionResult Upsert() //note the lack of paramters. The menu item from the form comes from the [BindProperty] declaration.
    {
        if (!ModelState.IsValid)
        {
            return View();
        }

        if (Int32.Parse(ApplicationUserObj.Id) == 0) 
        {
            _unitOfWork.ApplicationUser.Add(ApplicationUserObj);
        }
        else
        {
            _unitOfWork.ApplicationUser.Update(ApplicationUserObj);
        }

        _unitOfWork.Commit();
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Delete(int? id)
    {
        if (id == null || id == 0)
        {
            return NotFound();
        }

        var objFromDb = _unitOfWork.ApplicationUser.Get(m => Int32.Parse(m.Id) == id);

        if (objFromDb == null)
        {
            return NotFound();
        }

        return View(objFromDb);
    }


    [HttpPost, ActionName("Delete")]
    public IActionResult DeletePost(int? id)
    {
        var objFromDB = _unitOfWork.ApplicationUser.Get(m => Int32.Parse(m.ApplicationUserId) == id);
        if (objFromDB == null)
        {
            return NotFound();
        }
        _unitOfWork.ApplicationUser.Delete(objFromDB);
        _unitOfWork.Commit();

        return RedirectToAction("Index");
    }
}