﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Idea_Pending_SMART.Models
{
    public class Enrollment
    {
        [Required]
        [ForeignKey("Class")]
        public int ClassID { get; set; }

        [Required]
        [ForeignKey("Student")]
        public int StudentID { get; set; }
    }

}
