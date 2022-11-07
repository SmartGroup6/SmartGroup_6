using Idea_Pending_SMART.Interfaces;
using Idea_Pending_SMART.Models;
using Microsoft.AspNetCore.Mvc;


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

    ////Unsure of usage
    //[HttpGet]
    //public ViewResult Create()
    //{
    //    return View();
    //}

    //[HttpPost]
    //[ValidateAntiForgeryToken]
    //public IActionResult Create(Semester obj)
    //{
        
    //    if (ModelState.IsValid)
    //    {
    //        _unitOfWork.Semester.Add(obj); //internal add
    //        _unitOfWork.Commit(); //physical commit to DB table
    //        TempData["success"] = "Semester added to database Successfully";
    //        return RedirectToAction(defaultAction);
    //    }
    //    return View(obj);
    //}

    //[HttpGet]
    //public IActionResult Edit(int? id)
    //{
    //    if (id == null || id == 0)
    //        return NotFound();

    //    //grab that Category from the DB itself

    //    var objFromDb = _unitOfWork.Semester.Get(c => c.SemesterID == id);

    //    if (objFromDb == null)
    //    {
    //        return NotFound();
    //    }

    //    return View(objFromDb);
    //}


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

