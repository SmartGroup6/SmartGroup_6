﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Idea_Pending_SMART.Models
{
    public class Applicant
    {
        [Key]
        public int ApplicantID { get; set; }

        [Required]
        public string? AppStatus { get; set; }

/*
        [Required]
        [ForeignKey("Applications")]
        public int ApplicationID { get; set; }

        */
    }

}
