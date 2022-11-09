using System.ComponentModel.DataAnnotations;

namespace Idea_Pending_SMART.Models
{
    public class School
    {
        [Key]
        public int SchoolID { get; set; }

        [Required]
        //[Display(Name = "Food Name")]
        public string? SchoolName { get; set; }

        public string? Phone { get; set; }

    }

}
