using Idea_Pending_SMART.Interfaces;
using Idea_Pending_SMART.Models;
using Microsoft.AspNetCore.Mvc;



    [Area("Attendance")]
    public class AttendanceController : Controller
    {
   
        private readonly IUnitOfWork _unitOfWork;
        private string defaultAction = "Index";

     

        public AttendanceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ViewResult Index()
        {
            //    IEnumerable<Attendance> objAssignmentList = _unitOfWork.Attendance.GetAll();

            //   return View(objAttendancetList);

            IEnumerable<Attendance> ojbAttendance = _unitOfWork.Attendance.GetAll();
            return View(ojbAttendance);
        }


        private readonly IWebHostEnvironment _hostEnvironment;


        [BindProperty]
        public Attendance AttendanceObj { get; set; }



        [HttpGet]
        public IActionResult Upsert(int? id)
        {
            Attendance AttendanceObj = new Attendance();


            if (id != null)
            {
                AttendanceObj = _unitOfWork.Attendance.Get(s => s.AttendanceID == id);
                if (AttendanceObj == null)
                {
                    return NotFound();
                }
            }

            return View(AttendanceObj);
        }


        [HttpPost]
        public IActionResult Upsert()
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
        if (AttendanceObj.AttendanceID == 0)
        {
            _unitOfWork.Attendance.Add(AttendanceObj);
        }
        else
        {
            _unitOfWork.Attendance.Update(AttendanceObj);
        }

        _unitOfWork.Commit();
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Delete(int? id)
    {
        if (id == null || id == 0)
        {
            return NotFound();
        }

        var DbObj = _unitOfWork.Attendance.Get(a => a.AttendanceID == id);

        if (DbObj == null)
        {
            return NotFound();
        }

        return View(DbObj);
    }


    [HttpPost, ActionName("Delete")]
    public IActionResult DeletePost(int? id)
    {
        var DbObj = _unitOfWork.Attendance.Get(a => a.AttendanceID == id);
        if (DbObj == null)
        {
            return NotFound();
        }
        _unitOfWork.Attendance.Delete(DbObj);
        _unitOfWork.Commit();

        return RedirectToAction("Index");


        }







    }

