using Idea_Pending_SMART.Interfaces;
using Idea_Pending_SMART.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

[Area("SchoolManagement")]
public class CourseController : Controller
{
    private readonly IUnitOfWork _unitOfWork;
    /*
        +CreateGrade(GradeID, StudentID, LetterGrade, Percent, Pass)
        +UpdateGrade(StudentID,LetterGrade)
        +AddAttendance
        +AddNotes
        +Meals
        * */

    public CourseController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    //ctrl+k+c to comment, ctrl+k+u to uncomment
    public ViewResult Index()
    {
        IEnumerable<Course> objList = _unitOfWork.Course.GetAll();

        return View(objList);

    }

    /////////Upsert stuff
    //private readonly IWebHostEnvironment _hostEnvironment;

    //Bind apparently solves some headaches by binding the model to our forum
    [BindProperty]
    public Course CourseObj { get; set; }


    /*
     * We aren't going to have a separate edit/delete mode. Just upsert.
     * The id is optional, as you either pass it an id that gets edited, or you dont give it an id so it creates a new one.
     * */
    [HttpGet]
    public IActionResult Upsert(int? id) //optional, indicates editing or creating
    {
        Course CourseObj = new Course();

        if (id != null)
        {
            CourseObj = _unitOfWork.Course.Get(s => s.CourseID == id);
            if (CourseObj == null)
            {
                return NotFound();
            }
        }

        return View(CourseObj);
    }


    [HttpPost]
    public IActionResult Upsert() //note the lack of paramters. The menu item from the form comes from the [BindProperty] declaration.
    {
        if (!ModelState.IsValid)
        {
            return View();
        }

        if (CourseObj.CourseID == 0) 
        {
            _unitOfWork.Course.Add(CourseObj);
        }
        else
        {
            _unitOfWork.Course.Update(CourseObj);
        }

        _unitOfWork.Commit();
        return RedirectToAction("Index", "SchoolManagement");
    }

    [HttpGet]
    public IActionResult Delete(int? id)
    {
        if (id == null || id == 0)
        {
            return NotFound();
        }

        var objFromDb = _unitOfWork.Course.Get(m => m.CourseID == id);

        if (objFromDb == null)
        {
            return NotFound();
        }

        return View(objFromDb);
    }


    [HttpPost, ActionName("Delete")]
    public IActionResult DeletePost(int? id)
    {
        var objFromDB = _unitOfWork.Course.Get(m => m.CourseID == id);
        if (objFromDB == null)
        {
            return NotFound();
        }
        _unitOfWork.Course.Delete(objFromDB);
        _unitOfWork.Commit();

        return RedirectToAction("Index", "SchoolManagement");
    }
}