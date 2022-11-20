using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Idea_Pending_SMART.Models
{
    public class ApplicationUser : IdentityUser
    {

        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        public string ApplicationUserId { get; set; }

        public string Address { get; set; }

        public string County { get; set; }

        public string Zip { get; set; }

        public string Gender { get; set; }

        public string Race { get; set; }

        public DateTime BirthDate { get; set; }

        public string Income { get; set; }

        public string Education { get; set; }

        public string Residence { get; set; }

        public string Military { get; set; }

        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("Street Address")]
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        [DisplayName("Postal Code")]
        public string PostalCode { get; set; }

        [NotMapped]
        public string FullName { get { return FirstName + " " + LastName; } }

        //[Required]
        //[ForeignKey("Role")]
        //public int? RoleID { get; set; }

        //[Required]
        //[ForeignKey("Person")]
        //public int PersonID { get; set; }


    }

}
