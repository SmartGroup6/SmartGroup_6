using Idea_Pending_SMART.Interfaces;
using Idea_Pending_SMART.Models;
using Microsoft.AspNetCore.Mvc;


[Area("Assignment")]
public class AssignmentController : Controller
{
    private readonly IUnitOfWork _unitOfWork;
    private string defaultAction = "Index";
    
        /*
            +CreateAssignment(AssignN,Due,Score)
            +UpdateAssignment(AssignN,Score)
            +RemoveAssignment(AssignN)
            +getAssignmentDetlais(assignmentID)
        */

    public AssignmentController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    //ctrl+k+c to comment, ctrl+k+u to uncomment
    public ViewResult Index()
    {
        IEnumerable<Assignment> objAssignmentList = _unitOfWork.Assignment.GetAll();

        return View(objAssignmentList);

    }

    /////////Upsert stuff
    private readonly IWebHostEnvironment _hostEnvironment;

    //Bind apparently solves some headaches by binding the model to our forum
    [BindProperty]
    public Assignment AssignmenObj { get; set; }


    /*
     * We aren't going to have a separate edit/delete mode. Just upsert.
     * The id is optional, as you either pass it an id that gets edited, or you dont give it an id so it creates a new one.
     * */
    [HttpGet]
    public IActionResult Upsert(int? id) //optional, indicates editing or creating
    {
        Assignment AssignmenObj = new Assignment();

        //Get the semester we're editing, if it exists.
        if (id != null)
        {
            AssignmenObj = _unitOfWork.Assignment.Get(s => s.AssignmentID == id);
            if (AssignmenObj == null)
            {
                return NotFound();
            }
        }

        return View(AssignmenObj);
    }


    [HttpPost]
    public IActionResult Upsert() //note the lack of paramters. The menu item from the form comes from the [BindProperty] declaration.
    {
        if (!ModelState.IsValid)
        {
            return View();
        }

    //[HttpPost]
    //[ValidateAntiForgeryToken]
    //public IActionResult Edit(Semester obj)
    //{
    //    if (ModelState.IsValid)
    //    {
    //        _unitOfWork.Semester.Update(obj);
    //        _unitOfWork.Commit();
    //        TempData["success"] = "Semester updated successfully";
    //        return RedirectToAction(defaultAction);
    //    }
    //    return View(obj);
    //}


    //[HttpGet]
    //public IActionResult Delete(int? id)
    //{
    //    if (id == null || id == 0)
    //    {
    //        return NotFound();
    //    }

    //    var objFromDb = _unitOfWork.Semester.Get(c => c.SemesterID == id);

    //    if (objFromDb == null)
    //    {
    //        return NotFound();
    //    }

    //    return View(objFromDb);
    //}

    //[HttpPost, ActionName("Delete")]     //can change the method name and just map the button on the html page to this ActionName

    //public IActionResult DeletePost(int? id)
    //{
    //    var obj = _unitOfWork.Semester.Get(c => c.SemesterID == id);
    //    if (obj == null)
    //    { return NotFound(); }

    //    _unitOfWork.Semester.Delete(obj);
    //    _unitOfWork.Commit();
    //    TempData["success"] = "Semester was deleted Successfully";
    //    return RedirectToAction("Index");
    //}
}

        return RedirectToAction("Index");
    }
}
