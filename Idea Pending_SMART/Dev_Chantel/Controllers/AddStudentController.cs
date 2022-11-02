using Idea_Pending_SMART.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Idea_Pending_SMART.Dev_Chantel.Controllers
{
    public class AddStudentController : Controller
    {
        private IRepository _addStudentRepository;
        public AddStudentController(IRepository addStudentRepository)
        {
            _addStudentRepository = addStudentRepository;
        }

        public IActionResult AddStudent() => View(_addStudentRepository.Students);



    }
}
