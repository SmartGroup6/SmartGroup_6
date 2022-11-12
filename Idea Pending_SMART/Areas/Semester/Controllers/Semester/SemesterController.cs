using Idea_Pending_SMART.Interfaces;
using Idea_Pending_SMART.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

[Area("Semester")]
public class SemesterController : Controller
{
    private readonly IUnitOfWork _unitOfWork;
    private string defaultAction = "Index";
    /*
        +CreateGrade(GradeID, StudentID, LetterGrade, Percent, Pass)
        +UpdateGrade(StudentID,LetterGrade)
        +AddAttendance
        +AddNotes
        +Meals
        * */

    public SemesterController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    //ctrl+k+c to comment, ctrl+k+u to uncomment
    public ViewResult Index()
    {
        IEnumerable<Semester> objSemesterList = _unitOfWork.Semester.GetAll();

        return View(objSemesterList);

    }

    /////////Upsert stuff
    private readonly IWebHostEnvironment _hostEnvironment;

    //Bind apparently solves some headaches by binding the model to our forum
    [BindProperty]
    public Semester SemesterObj { get; set; }


    /*
     * We aren't going to have a separate edit/delete mode. Just upsert.
     * The id is optional, as you either pass it an id that gets edited, or you dont give it an id so it creates a new one.
     * */
    [HttpGet]
    public IActionResult Upsert(int? id) //optional, indicates editing or creating
    {
        Semester SemesterObj = new Semester();

        //Get the semester we're editing, if it exists.
        if (id != null)
        {
            SemesterObj = _unitOfWork.Semester.Get(s => s.SemesterID == id);
            if (SemesterObj == null)
            {
                return NotFound();
            }
        }

        return View(SemesterObj);
    }


    [HttpPost]
    public IActionResult Upsert() //note the lack of paramters. The menu item from the form comes from the [BindProperty] declaration.
    {
        if (!ModelState.IsValid)
        {
            return View();
        }

        if (SemesterObj.SemesterID == 0) //New semester
        {
            _unitOfWork.Semester.Add(SemesterObj);
        }
        else //Edit semester
        {
            _unitOfWork.Semester.Update(SemesterObj);
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

        var objFromDb = _unitOfWork.Semester.Get(m => m.SemesterID == id);

        if (objFromDb == null)
        {
            return NotFound();
        }

        return View(objFromDb);
    }


    [HttpPost, ActionName("Delete")]
    public IActionResult DeletePost(int? id)
    {
        var objFromDB = _unitOfWork.Semester.Get(m => m.SemesterID == id);
        if (objFromDB == null)
        {
            return NotFound();
        }
        _unitOfWork.Semester.Delete(objFromDB);
        _unitOfWork.Commit();

        return RedirectToAction("Index");
    }
}

