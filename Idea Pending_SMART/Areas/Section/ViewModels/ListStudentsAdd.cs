using Idea_Pending_SMART.Models;

namespace Idea_Pending_SMART.Areas.Section.ViewModels
{
    //vm to show student lists
    public class ListStudentsAdd
    {
        public IEnumerable<Enrollment>? Enrollment { get; set; }
        public IEnumerable<Class>? Class { get; set; }
        public IEnumerable<ClassTime>? ClassTime { get; set; }
        public IEnumerable<Models.Student>? Student { get; set; }
    }
}
