using System.ComponentModel.DataAnnotations;

namespace Idea_Pending_SMART.Models
{
    public class RegistrationRequest
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress]
        public string? Email { get; set; }


    }
}
