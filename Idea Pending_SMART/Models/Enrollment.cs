﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Idea_Pending_SMART.Models
{
    public class Enrollment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Display(Name = "EnrollmentID")]
        public int EnrollmentID { get; set; }

        [Required]
        [Display(Name = "ClassID")]
        [ForeignKey("Class")]
        public int ClassID { get; set; }


        [ForeignKey("StudentID")]
        public int StudentID { get; set; }
        public virtual Student? Student { get; set; }

        public virtual Class? Class { get; set; }

    }

}