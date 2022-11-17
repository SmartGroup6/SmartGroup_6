using Idea_Pending_SMART.Interfaces;
using Idea_Pending_SMART.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

[Area("SchoolManagement")]
public class SchoolController : Controller
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IWebHostEnvironment _hostEnvironment;

    [BindProperty]
    public School SchoolObj { get; set; }

    public SchoolController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    //ctrl+k+c to comment, ctrl+k+u to uncomment
    public ViewResult Index()
    {
        IEnumerable<School> obList = _unitOfWork.School.GetAll();

        return View(obList);

    }

    [HttpGet]
    public IActionResult Upsert(int? id) //optional, indicates editing or creating
    {
        School SchoolObj = new School();
        if (id != null)
        {
            SchoolObj = _unitOfWork.School.Get(s => s.SchoolID == id);
            if (SchoolObj == null)
            {
                return NotFound();
            }
        }

        return View(SchoolObj);
    }

    [HttpPost]
    public IActionResult Upsert()
    {
        if (!ModelState.IsValid)
        {
            return View();
        }

        if (SchoolObj.SchoolID == 0)
        {
            _unitOfWork.School.Add(SchoolObj);
        }
        else 
        {
            _unitOfWork.School.Update(SchoolObj);
        }

        _unitOfWork.Commit();
        return RedirectToAction("Index", "SchoolManagement");
    }

    [HttpGet]
    public IActionResult Delete(int? id)
    {
        if (id == null || id == 0)
        {
            return NotFound();
        }

        var objFromDb = _unitOfWork.School.Get(m => m.SchoolID == id);

        if (objFromDb == null)
        {
            return NotFound();
        }

        return View(objFromDb);
    }


    [HttpPost, ActionName("Delete")]
    public IActionResult DeletePost(int? id)
    {
        var objFromDB = _unitOfWork.School.Get(m => m.SchoolID == id);
        if (objFromDB == null)
        {
            return NotFound();
        }
        _unitOfWork.School.Delete(objFromDB);
        _unitOfWork.Commit();

        return RedirectToAction("Index", "SchoolManagement");
    }
}