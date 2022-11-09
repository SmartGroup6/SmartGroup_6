using Idea_Pending_SMART.Interfaces;

namespace Idea_Pending_SMART.Areas.Student.Controllers.Student
{
    //This should probably be an AddStudent method in the Student controller.
    public class AddStudentController
    {
        /*
            +checkCoursePrereq(CourseID)
            +checkStudentAvailable(StudentID)
            +checkClassSpace(ClassID)
            +canStudentBeAdded : bool
            +AddStudent(StudentID)
         */

        private IUnitOfWork _addStudentRepository;
        public AddStudentController(IUnitOfWork addStudentRepository)
        {
            _addStudentRepository = addStudentRepository;
        }

        //public IActionResult AddStudent() => View(_addStudentRepository.Students);
    }
}
