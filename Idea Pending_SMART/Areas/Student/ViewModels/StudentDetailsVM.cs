using Idea_Pending_SMART.Models;
namespace Idea_Pending_SMART.Areas.Student.ViewModels
{
    public class StudentDetailsVM
    {
        //vm to show student details
        public IEnumerable<Enrollment>? Enrollment { get; set; }
        public IEnumerable<Class>? Class { get; set; }
        public IEnumerable<ClassTime>? ClassTime { get; set; }
        public IEnumerable<Models.Student>? Student { get; set; }
        public IEnumerable<Person>? Person { get; set; }
        public IEnumerable<Sponsor>? Sponsors { get; set; }
        public IEnumerable<StudentNote>? StudentNotes { get; set;}



    }
}

