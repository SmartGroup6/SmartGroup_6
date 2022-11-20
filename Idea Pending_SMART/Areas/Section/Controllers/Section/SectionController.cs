using Idea_Pending_SMART.Areas.Section.ViewModels;
using Idea_Pending_SMART.Interfaces;
using Idea_Pending_SMART.Models;
using Microsoft.AspNetCore.Mvc;


[Area("Section")]
public class SectionController : Controller
{
    private readonly IUnitOfWork _unitOfWork;
    private string defaultAction = "Index";


    public SectionController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public ViewResult Index()
    {
        IEnumerable<Class> objClasses = _unitOfWork.Class.GetAll();
        ClasslistVM cvm = new ClasslistVM();

        cvm.Class = _unitOfWork.Class.GetAll();
        cvm.ClassTime = _unitOfWork.ClassTime.GetAll();

        return View(cvm);
    }


    [HttpGet]
    public IActionResult Open(int? id)
    {
        IEnumerable<Enrollment> obj = _unitOfWork.Enrollment.List(c => c.ClassID == id, orderBy: c=>c.StudentID, "Class,Student");
        return View(obj);
    }

    [HttpGet]
    public IActionResult ClassDescription(int? id)
    {
        Class ClassObj = new Class();
        if (id != null)
        {
            ClassObj = _unitOfWork.Class.Get(c => c.ClassID == id);
        }

        return View(ClassObj);
    }

    [HttpGet]
    public IActionResult ListStudentsAdd(int? id, int? classtime)
    {
        
        
        ListStudentsAdd lsa = new ListStudentsAdd();
        lsa.Class = _unitOfWork.Class.GetAll(c=>c.ClassID == id);
        //maybe use this to remove and enrollments with class times at 2
         lsa.Enrollment = _unitOfWork.Enrollment.GetAll(e => e.ClassID != id && e.Class.ClassTimeID != classtime);


         lsa.Enrollment = _unitOfWork.Enrollment.GetAll(e => e.ClassID != id && e.Class.ClassTimeID != 2);

        lsa.Student = _unitOfWork.Student.GetAll();
        lsa.ClassTime = _unitOfWork.ClassTime.GetAll();

        return View(lsa);
    }



    [HttpGet]
    public ViewResult Add(int? sid, int? cid)
    {
        ViewBag.cid = cid;
        ViewBag.sid = sid;
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Add(Enrollment obj)
    {
       if (ModelState.IsValid)
        {
            _unitOfWork.Enrollment.Add(obj); //internal add
            _unitOfWork.Commit(); //physical commit to DB table
            TempData["success"] = "Student added to database Successfully";
            return RedirectToAction(defaultAction);
        }
       return View(obj);
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