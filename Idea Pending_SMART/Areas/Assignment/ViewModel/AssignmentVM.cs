using Microsoft.AspNetCore.Mvc.Rendering;


namespace Idea_Pending_SMART.Areas.Assignment.ViewModel
{
    public class AssignmentVM
    {
        public AssignmentVM? Assignment { get; set; }
        public IEnumerable<SelectListItem>? ClassList { get; set; }


    }
}
