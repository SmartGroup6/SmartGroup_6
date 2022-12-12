using Idea_Pending_SMART.Areas.Assignment.ViewModel;
using Idea_Pending_SMART.Interfaces;
using Idea_Pending_SMART.Models;
using Microsoft.AspNetCore.Mvc;


[Area("Assignment")]
public class AssignmentController : Controller
{
    [BindProperty]
    public AssignmentVM AssignmentObj { get; set; }

    private readonly IUnitOfWork _unitOfWork;


    public AssignmentController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }


    public ViewResult Index()
    {
        IEnumerable<Assignment> objAssignmentList = _unitOfWork.Assignment.GetAll();

        return View(objAssignmentList);

    }

  
    private readonly IWebHostEnvironment _hostEnvironment;

 
    [BindProperty]
    public Assignment AssignmenObj { get; set; }


   
    [HttpGet]
    public IActionResult Upsert(int? id) 
    {
        Assignment AssignmenObj = new Assignment();

        if (id != null)
        {
            AssignmenObj = _unitOfWork.Assignment.Get(s => s.AssignmentID == id);
            if (AssignmenObj == null)
            {
                return NotFound();
            }
        }

        return View(AssignmenObj);
    }


    [HttpPost]
    public IActionResult Upsert() 
    {
        if (!ModelState.IsValid)
        {
            return View();
        }

        if (AssignmenObj.AssignmentID == 0)
        {
            _unitOfWork.Assignment.Add(AssignmenObj);
        }
        else 
        {
            _unitOfWork.Assignment.Update(AssignmenObj);
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

        var DbObj = _unitOfWork.Assignment.Get(a => a.AssignmentID == id);

        if (DbObj == null)
        {
            return NotFound();
        }

        return View(DbObj);
    }


    [HttpPost, ActionName("Delete")]
    public IActionResult DeletePost(int? id)
    {
        var DbObj = _unitOfWork.Assignment.Get(a => a.AssignmentID == id);
        if (DbObj == null)
        {
            return NotFound();
        }
        _unitOfWork.Assignment.Delete(DbObj);
        _unitOfWork.Commit();

        return RedirectToAction("Index");
    }
}
