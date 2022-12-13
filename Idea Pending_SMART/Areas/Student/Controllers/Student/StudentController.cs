using Idea_Pending_SMART.Interfaces;
using Idea_Pending_SMART.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Area("Student")]
public class StudentController : Controller
{
    private readonly IUnitOfWork _unitOfWork;
    /*
        +Float:academicScore
        +Date:DOB
        +String:DeterminationNote
        +String:DistanceNote
        +int:InstructorScore
        +int:SocWorkSCore
        +int:AdminSCore
        +int:TotalScore
        +Date:SubmissionDate
        +Bool:ChoppaTransport
        +Bool:MealNeeded
     */

    /*
        +rateStudent()
        +changeStudentStatus()
        +checkGPA() 
        +checkAge() 
        +checkFinancials()
        +checkDistance()
        +isAppComplete()
        +checkStatus() 
     */

    public StudentController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    //ctrl+k+c to comment, ctrl+k+u to uncomment
    public ViewResult Index()
    {
        IEnumerable<Student> objStudentList = _unitOfWork.Student.GetAll();
        return View(objStudentList);
    }

    /////////Upsert stuff
    //private readonly IWebHostEnvironment _hostEnvironment;
    //Bind apparently solves some headaches by binding the model to our forum
    [BindProperty]
    public Student StudentObj { get; set; }

    /*
     * We aren't going to have a separate edit/delete mode. Just upsert.
     * The id is optional, as you either pass it an id that gets edited, or you dont give it an id so it creates a new one.
     * */
    [HttpGet]
    public IActionResult Upsert(int? id) //optional, indicates editing or creating
    {
        Student StudentObj = new Student();

        //Get the semester we're editing, if it exists.
        if (id != null)
        {
            StudentObj = _unitOfWork.Student.Get(s => s.StudentID == id);
            if (StudentObj == null)
            {
                return NotFound();
            }
        }

        return View(StudentObj);
    }


    [HttpPost]
    public IActionResult Upsert() //note the lack of paramters. The Student from the form comes from the [BindProperty] declaration.
    {
        if (!ModelState.IsValid)
        {
            return View();
        }

        if (StudentObj.StudentID == 0) //New semester
        {
            _unitOfWork.Student.Add(StudentObj);
        }
        else //Edit semester
        {
            _unitOfWork.Student.Update(StudentObj);
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

        var objFromDb = _unitOfWork.Student.Get(a => a.StudentID == id);

        if (objFromDb == null)
        {
            return NotFound();
        }

        return View(objFromDb);
    }

    [HttpPost, ActionName("Delete")]     //can change the method name and just map the button on the html page to this ActionName

    public IActionResult DeletePost(int? id)
    {
        var obj = _unitOfWork.Student.Get(a => a.StudentID == id);
        if (obj == null)
        { return NotFound(); }

        _unitOfWork.Student.Delete(obj);
        _unitOfWork.Commit();
        //TempData["success"] = "Student was deleted Successfully";
        return RedirectToAction("Index");
    }
}
