using Idea_Pending_SMART.Dev_Chantel.Models;
using Microsoft.AspNetCore.Mvc;

namespace Idea_Pending_SMART.Dev_Chantel.Controllers
{
    public class ClassroomController : Controller
    {
        private IClassroomRepository _classroomRepository;
        public ClassroomController(IClassroomRepository classroomRepository)
        {
            _classroomRepository = classroomRepository;
        }

        public IActionResult ClassroomList() => View(_classroomRepository.Classrooms);


   //     public IActionResult ClassroomList()
   //     {
   //         return View();
   //     }
    }
}
