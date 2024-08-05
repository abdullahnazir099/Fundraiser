using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace FundRaisers.Models
{
    public class Event
    {
        public int Id { get; set; }

        [Required]

        [Display(Name = "Fundraise For")]
        [DataType(DataType.Text)]
        public string? Fundraise_for { get; set; }

        [Required]
        [Display(Name = "Target Amount")]
        [DataType(DataType.Currency)]
        public int Target_amount { get; set; }

        [Required]
        [Display(Name = "Description")]
        [DataType(DataType.Text)]
        public string? Description { get; set; }

        [Required]
        [Display(Name = "Location")]
        [DataType(DataType.Text)]
        public string? Location { get; set; }

        [Required]
        [Display(Name = "Zipcode")]
        [DataType(DataType.PostalCode)]
        public string? Zipcode { get; set; }

        [Required]
        [Display(Name = "Creation Date")]
        [DataType(DataType.Date)]
        public DateTime Date_of_creation { get; set; }

        [Required]
        [Display(Name = "Receiver Name")]
        [DataType(DataType.Text)]
        public string? Receiver_name { get; set; }

        [Required]
        [Display(Name = "Receiver Email")]
        [DataType(DataType.EmailAddress)]
        public string? Receiver_Email { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string? Receiver_phone { get; set; }
    }
}
