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
        IEnumerable<Application> objList = _unitOfWork.Application.GetAll();
        return View(objList);
    }


    [HttpGet]
    public ViewResult Create()
    {
        return View();

    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Application obj)
    {
        if (ModelState.IsValid)
        {
            _unitOfWork.Application.Add(obj); //internal add
            _unitOfWork.Commit(); //physical commit to DB table
            //TempData["success"] = "Application added to database Successfully";
            return RedirectToAction("Index");
        }
        return View(obj);
    }

    [HttpGet]
    public IActionResult Edit(int? id)
    {
        if (id == null || id == 0)
        {
            return NotFound();
        }
        //grab that Application from the DB itself

        var objFromDb = _unitOfWork.Application.Get(a => a.ApplicationID == id);

        if (objFromDb == null)
        {
            return NotFound();
        }

        return View(objFromDb);
    }


    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(Application obj)
    {
        if (ModelState.IsValid)
        {
                _unitOfWork.Application.Update(obj);
                _unitOfWork.Commit();
                // TempData["success"] = "Application updated successfully";
                return RedirectToAction("Index");
            
            
        }
        return View(obj);
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
