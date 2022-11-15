using Idea_Pending_SMART.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Idea_Pending_SMART.Areas.Semester.ViewModels
{
    public class ManageVM
    {
        //public ManageVM? Manage { get; set; }

        public IEnumerable<Models.Semester>? Semester  { get; set; }
        public IEnumerable<School>? School { get; set; }

        public IEnumerable<Course>? Course { get; set; }



    }
}