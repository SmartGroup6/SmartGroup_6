using Idea_Pending_SMART.Interfaces;
using Idea_Pending_SMART.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Area("Application")]
public class ApplicationController : Controller
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
        +rateApplication()
        +changeStudentStatus()
        +checkGPA() 
        +checkAge() 
        +checkFinancials()
        +checkDistance()
        +isAppComplete()
        +checkStatus() 
     */

    public ApplicationController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    //ctrl+k+c to comment, ctrl+k+u to uncomment
    public ViewResult Index()
    {
        IEnumerable<Application> objApplicationList = _unitOfWork.Application.GetAll();
        return View(objApplicationList);
    }

    /////////Upsert stuff
    private readonly IWebHostEnvironment _hostEnvironment;
    //Bind apparently solves some headaches by binding the model to our forum
    [BindProperty]
    public Application ApplicationObj { get; set; }

    /*
     * We aren't going to have a separate edit/delete mode. Just upsert.
     * The id is optional, as you either pass it an id that gets edited, or you dont give it an id so it creates a new one.
     * */
    [HttpGet]
    public IActionResult Upsert(int? id) //optional, indicates editing or creating
    {
        Application ApplicationObj = new Application();

        //Get the semester we're editing, if it exists.
        if (id != null)
        {
            ApplicationObj = _unitOfWork.Application.Get(s => s.ApplicationID == id);
            if (ApplicationObj == null)
            {
                return NotFound();
            }
        }

        return View(ApplicationObj);
    }


    [HttpPost]
    public IActionResult Upsert() //note the lack of paramters. The Application from the form comes from the [BindProperty] declaration.
    {
        if (!ModelState.IsValid)
        {
            return View();
        }

        if (ApplicationObj.ApplicationID == 0) //New semester
        {
            _unitOfWork.Application.Add(ApplicationObj);
        }
        else //Edit semester
        {
            _unitOfWork.Application.Update(ApplicationObj);
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

        var objFromDb = _unitOfWork.Application.Get(a => a.ApplicationID == id);

        if (objFromDb == null)
        {
            return NotFound();
        }

        return View(objFromDb);
    }

    [HttpPost, ActionName("Delete")]     //can change the method name and just map the button on the html page to this ActionName

    public IActionResult DeletePost(int? id)
    {
        var obj = _unitOfWork.Application.Get(a => a.ApplicationID == id);
        if (obj == null)
        { return NotFound(); }

        _unitOfWork.Application.Delete(obj);
        _unitOfWork.Commit();
        //TempData["success"] = "Application was deleted Successfully";
        return RedirectToAction("Index");
    }
}
