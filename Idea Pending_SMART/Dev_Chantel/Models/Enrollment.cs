using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Idea_Pending_SMART.Dev_Chantel.Models
{

    public class Enrollment
    {
        [Key]
        public int EnrollmentID { get; set; }
        public int ClassID { get; set; }
        
        public int StudentID { get; set; }
        protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Enrollment>().HasKey(e => new { e.ClassID, e.StudentID });
        }
    }
}
