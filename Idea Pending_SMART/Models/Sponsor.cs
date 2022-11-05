using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Idea_Pending_SMART.Models
{
    public class Sponsor
    {
        [Key]
        public int SponsorID { get; set; }

        //NOT required
        public string? CompanyName { get; set; }
        //NOT required
        public string? DonationTotal { get; set; }
        

        [Required]
        [ForeignKey("Person")]
        public int PersonID { get; set; }


    }

}
