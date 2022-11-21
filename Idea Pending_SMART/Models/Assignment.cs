using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Idea_Pending_SMART.Models
{
    public class Assignment
    {

        [Key]
        public int AssignmentID { get; set; }

        [Required]
        public string? AssignmentName { get; set; }

        public string? AssignmentDescription { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? AssignmentIssuetDate { get; set; } = DateTime.Now;

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? AssignmentDueDate { get; set; } = DateTime.Now;


        public int? ClassID { get; set; }



        public int? AssignmentTotalMarks { get; set; }
        [ForeignKey("ClassID")]

    
        public virtual Class? Class { get; set; }

    }
}