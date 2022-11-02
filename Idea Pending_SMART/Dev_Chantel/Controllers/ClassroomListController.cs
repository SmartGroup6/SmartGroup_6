using Idea_Pending_SMART.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Idea_Pending_SMART.Dev_Chantel.Controllers
{
    public class ClassroomListController : Controller
    {
        private IRepository _classroomRepository;
        public ClassroomListController(IRepository classroomRepository)
        {
            _classroomRepository = classroomRepository;
        }

        public IActionResult ClassroomList() => View(_classroomRepository.Classrooms);

    }
}
