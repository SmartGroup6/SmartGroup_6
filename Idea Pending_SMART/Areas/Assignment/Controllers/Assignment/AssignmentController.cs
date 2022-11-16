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

        if (AssignmenObj.AssignmentID == 0) //New semester
        {
            _unitOfWork.Assignment.Add(AssignmenObj);
        }
        else //Edit semester
        {
            _unitOfWork.Assignment.Update(AssignmenObj);
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

        var objFromDb = _unitOfWork.Assignment.Get(m => m.AssignmentID == id);

        if (objFromDb == null)
        {
            return NotFound();
        }

        return View(objFromDb);
    }


    [HttpPost, ActionName("Delete")]
    public IActionResult DeletePost(int? id)
    {
        var objFromDB = _unitOfWork.Assignment.Get(m => m.AssignmentID == id);
        if (objFromDB == null)
        {
            return NotFound();
        }
        _unitOfWork.Assignment.Delete(objFromDB);
        _unitOfWork.Commit();

        return RedirectToAction("Index");
    }
}

