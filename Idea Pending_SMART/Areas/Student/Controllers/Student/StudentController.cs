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


    public ViewResult StudentDetails(int? sid)
    {
        IEnumerable<Enrollment> obj = _unitOfWork.Enrollment.List(c => c.StudentID == sid, orderBy: c => c.StudentID, "Class,Student");
        return View(obj);

    }


}

