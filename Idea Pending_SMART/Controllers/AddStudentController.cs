using Idea_Pending_SMART.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Idea_Pending_SMART.Controllers
{
    public class AddStudentController
    {
        /*
            +checkCoursePrereq(CourseID)
            +checkStudentAvailable(StudentID)
            +checkClassSpace(ClassID)
            +canStudentBeAdded : bool
            +AddStudent(StudentID)
         */

        private IRepository _addStudentRepository;
        public AddStudentController(IRepository addStudentRepository)
        {
            _addStudentRepository = addStudentRepository;
        }

        public IActionResult AddStudent() => View(_addStudentRepository.Students);
    }
}
