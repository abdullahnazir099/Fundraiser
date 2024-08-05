using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace FundRaisers.Models
{
    public class Donor
    {

        public int Id { get; set; }

        [Required]
        [Display(Name = "Name")]
        [DataType(DataType.Text)]
        public String? Name { get; set; }

        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public String? Email { get; set; }

        [Required]
        [Display(Name = "Contact Number")]
        [DataType(DataType.Text)]
        public String? Contact_no { get; set; }

        [Required]
        [Display(Name = "Address")]
        [DataType(DataType.Text)]
        public String? Address { get; set; }

        [Required]
        [Display(Name = "Zipcode")]
        [DataType(DataType.PostalCode)]
        public int Zipcode { get; set; }

        [Required]
        [Display(Name = "Donate For")]
        [DataType(DataType.Text)]
        public String? Donation_for { get; set; }

        [Required]
        [Display(Name = "Card Number")]
        [DataType(DataType.CreditCard)]
        public int Card_no { get; set; }

        [Required]
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public String? Date { get; set; }


        [Required]

        [Display(Name = "Amount")]
        [DataType(DataType.Currency)]
        public int Amount { get; set; }
    }
}
