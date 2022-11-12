using Microsoft.AspNetCore.Mvc.Rendering;

namespace Idea_Pending_SMART.Areas.Section.ViewModels
{
    public class EnrollmentVM
    {
        public EnrollmentVM? Enrollment { get; set; }

        public IEnumerable<SelectListItem>? ClassList { get; set; }
        public IEnumerable<SelectListItem>? StudentList { get; set; }



    }
}