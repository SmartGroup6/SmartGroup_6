﻿using Idea_Pending_SMART.Interfaces;
using Idea_Pending_SMART.Models;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;

[Area("Section")]
public class SectionController : Controller
{
    private readonly IUnitOfWork _unitOfWork;
    private string defaultAction = "Index";

    /*
        +getClassDetails(ClassID)
        +checkClassSpace(ClassID)
        +canClassChangeTime : bool
        +canStudentAttend :bool
        +openAddStudentPage()
        +RemoveStudent(StudentID)
        +checkClassTimes(ClassID)
        +checkStudentAvailable(StudentID)
        +changeTime(ClassID, ClassTime)
        +changeDetail(ClassID, ClassDetails)
        +changeStudentMax(ClassID, StudentCount)
        +getCourseDetails(CourseID)
    */
    
    public SectionController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
 
    //ctrl+k+c to comment, ctrl+k+u to uncomment
    public ViewResult Index()
    {
        IEnumerable<Class> obj = _unitOfWork.Class.GetAll();
        return View(obj);
    }




    [HttpGet]
    public IActionResult Open(int? id)
    {
        //     IEnumerable<Enrollment> obj = _unitOfWork.Enrollment.GetAll(c => c.ClassID == id);
        var student = _unitOfWork.Student;
        IEnumerable<Enrollment> obj = _unitOfWork.Enrollment.GetAll(c => c.ClassID == id);
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

