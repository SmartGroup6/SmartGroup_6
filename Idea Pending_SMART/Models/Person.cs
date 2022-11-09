using System.ComponentModel.DataAnnotations;

namespace Idea_Pending_SMART.Models
{
    public class Person
    {
        [Key]
        public int PersonID { get; set; }

        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]
        public string? Phone { get; set; }

        [Required]
        public string? StreetAddress { get; set; }

        //NOT required
        public string? ApartmentNum { get; set; }

        //NOT required
        public string? AddressGPSLatitude { get; set; }

        //NOT required
        public string? AddressGPSLongitude { get; set; }

        [Required]
        public string? AddressCity { get; set; }

        [Required]
        public string? AddressState { get; set; }

    }

}
