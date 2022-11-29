using Idea_Pending_SMART.Areas.Student.ViewModels;
using Idea_Pending_SMART.Interfaces;
using Idea_Pending_SMART.Models;
using Microsoft.AspNetCore.Mvc;


[Area("Student")]
public class StudentController : Controller
{
    private readonly IUnitOfWork _unitOfWork;
    private string defaultAction = "Index";
   

    public StudentController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }


    public ViewResult StudentDetails(int sid)
    {
        StudentDetailsVM sdvm = new StudentDetailsVM();
        sdvm.Class = _unitOfWork.Class.GetAll();
        sdvm.ClassTime = _unitOfWork.ClassTime.GetAll();
        sdvm.Student = (IEnumerable<Student>?)_unitOfWork.Student.GetAll(s => s.StudentID == sid);
        sdvm.Person = _unitOfWork.Person.GetAll();
        sdvm.Sponsors = _unitOfWork.Sponsor.GetAll();
        sdvm.StudentNotes = _unitOfWork.StudentNote.GetAll(sn => sn.StudentID == sid);
        sdvm.Enrollment = _unitOfWork.Enrollment.GetAll(e => e.StudentID == sid);


        return View(sdvm);
    }


}

