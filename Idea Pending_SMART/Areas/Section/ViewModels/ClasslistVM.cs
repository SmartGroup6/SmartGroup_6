using Idea_Pending_SMART.Models;
using Microsoft.AspNetCore.Mvc.Rendering;



using Idea_Pending_SMART.Models;

namespace Idea_Pending_SMART.Areas.Section.ViewModels
{
    public class ClasslistVM
    {
        public IEnumerable<Models.Class>? Class { get; set; }
        public IEnumerable<ClassTime>? ClassTime { get; set; }
    }
}