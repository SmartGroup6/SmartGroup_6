using Idea_Pending_SMART.Interfaces;
using Microsoft.AspNetCore.Mvc;



[Area("Instructor")]
public class ClassController : Controller
{
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
    private IRepository _classroomRepository;
    /*public ClassController(IRepository classroomRepository)
    {
        _classroomRepository = classroomRepository;
    }*/

    public IActionResult ClassroomList() => View();
}


